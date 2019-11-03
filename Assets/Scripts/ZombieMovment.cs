using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovment : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody2D myRigidbody;
    private Transform player;
    private Vector2 movement;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 180;
        myRigidbody.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        myRigidbody.MovePosition((Vector2)transform.position + (direction*speed*Time.deltaTime));
    }
}
