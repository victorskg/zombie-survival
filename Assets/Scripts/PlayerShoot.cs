using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;

    private Animator animator;
    private Vector3 lastDirection;
    private Vector3 bulletDirection;

    void Start() {
        animator = GetComponent<Animator>();
        lastDirection = new Vector3(-1, 0, 0);
    }

    // Update is called once per frame
    void Update() {
        UpdateBulletDirection();
        if (Input.GetKeyDown("z")) {
            Shoot();
        } else {
            animator.SetBool("shooting", false);
        }
    }

    void Shoot() {
        animator.SetBool("shooting", true);
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(lastDirection * bulletForce, ForceMode2D.Impulse);
    }

    void UpdateBulletDirection() {
        bulletDirection.x = Input.GetAxisRaw("Horizontal");
        bulletDirection.y = Input.GetAxisRaw("Vertical");

        if (bulletDirection != Vector3.zero) {
            lastDirection = bulletDirection;
        }
    }
}
