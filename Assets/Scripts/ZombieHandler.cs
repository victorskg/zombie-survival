using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHandler : MonoBehaviour {

    private Transform player;
    private Animator animator;
    private float limit = 1.4f;
    public HealthBar healthBar;
    private Rigidbody2D myRigidbody;
    public HealthSystem healthSystem;
    private PlayerHealth playerHealth;

    void Start() {
        this.healthSystem = new HealthSystem(100.0f);
        this.healthBar.Setup(this.healthSystem);

        this.animator = this.GetComponent<Animator>();
        this.myRigidbody = GetComponent<Rigidbody2D>();
        this.player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        this.playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    void Update() {
        HandlePlayerPosition();
    }

    void OnCollisionEnter2D(Collision2D col) {
        switch(col.gameObject.tag) {
            case "Bullet":
                HandleBulletCollision(col);
                break;
            case "Player":
                HandlePlayerCollision(col);
                break;
            default: break;
        }
    }

    void HandlePlayerPosition() {
        Vector3 distance = (Vector2) player.position - myRigidbody.position;
        if (Mathf.Abs(distance.x) >= limit || Mathf.Abs(distance.y) >= limit) {
            animator.SetBool("attack", false);
        }
    }

    void HandleBulletCollision(Collision2D col) {
        healthBar.healthSystem.Damage(10.0f);
        if (healthBar.healthSystem.GetHealth() == 0.0f) {
            Hud.kills += 1;
            Destroy(gameObject);
        }
    } 

    void HandlePlayerCollision(Collision2D col) {
        if (animator.gameObject.activeSelf){
            animator.SetBool("attack", true);
        }
        playerHealth.TakeDamage();
    }
}
