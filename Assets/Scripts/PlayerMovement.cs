using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public Camera camera;

    private Vector2 movement;
    private Vector2 mousePos;
    private Animator animator;
    private Rigidbody2D playerRigidBody;

    // Start is called before the first frame update
    void Start() {
        animator = GetComponent<Animator>();
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate() {
        playerRigidBody.MovePosition(playerRigidBody.position + movement * speed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - playerRigidBody.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        playerRigidBody.rotation = angle;
    }
}
