using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHandler : MonoBehaviour {

    public HealthBar healthBar;
    public HealthSystem healthSystem;
    
    void Start() {
        this.healthSystem = new HealthSystem(100.0f);
        this.healthBar.Setup(this.healthSystem);
    }

    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag == "Bullet") {
            healthBar.healthSystem.Damage(10.0f);
        }

        if(healthBar.healthSystem.GetHealth() == 0.0f) {
            Destroy(gameObject);
        }
    }
}
