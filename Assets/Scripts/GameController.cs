using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    
    public int currentWave;
    public int zombieIncrement;
    public GameObject[] zombies;
    public GameObject zombiePrefab;

    private Vector3[] spawns = new [] { 
        new Vector3(11.17f, -4f, 0), 
        new Vector3(-15.14f, -4.42f, 0),
        new Vector3(-0.4f, 8.57f, 0),
        new Vector3(18.4f, 10.57f, 0) 
    };

    void Start() {
        currentWave = 1;
        zombieIncrement = 2;
    }

    // Update is called once per frame
    void Update() {
        zombies = GameObject.FindGameObjectsWithTag("Zombie");
        ControlWave();
    }

    void ControlWave() {
        if (zombies.Length == 0) {
            currentWave++;
            NextWave();
        }
    }

    void NextWave() {
        int pos = 0;
        for (int i = 0; i < currentWave + zombieIncrement; i++) {
            if (pos > 3) pos = 0;
            Instantiate(zombiePrefab, spawns[pos], Quaternion.identity);
            pos++;
        }
    }
}
