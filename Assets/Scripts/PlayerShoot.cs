﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;

    private Vector3 lastDirection;
    private Vector3 bulletDirection;
    private AudioSource shootSource;

    void Start() {
        lastDirection = new Vector3(-1, 0, 0);
        shootSource = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
     
    }

    // Update is called once per frame
    void Update() {
        UpdateBulletDirection();
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }

    void Shoot() {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
        shootSource.Play();
    }

    void UpdateBulletDirection() {
        bulletDirection.x = Input.GetAxisRaw("Horizontal");
        bulletDirection.y = Input.GetAxisRaw("Vertical");

        if (bulletDirection != Vector3.zero) {
            lastDirection = bulletDirection;
        }
    }
}
