using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem {

    private float health;
    private float maxHealth;

    public HealthSystem(float maxHealth) {
        this.maxHealth = maxHealth;
        this.health = maxHealth;
    }

    public void Damage(float damage) {
        this.health -= damage;
        if (this.health < 0) health = 0.0f;
    }

    public float GetHealth() {
        return this.health;
    }

    public float GetHealthPercent() {
        return health / maxHealth;
    }
}
