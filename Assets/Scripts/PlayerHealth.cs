using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    private int health = 100;
    private int zombieDamage = 10;

    void Start() {
        health = 100;
        zombieDamage = 10;
    }

    public int TakeDamage() {
        health -= zombieDamage;
        
        if (health < 0) {
            health = 0;
        }
        
        return health;
    }

    public int GetHealth() {
        return health;
    }

    public int GetDamage() {
        return zombieDamage;
    }
}
