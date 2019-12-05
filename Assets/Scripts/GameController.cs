using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    
    public int currentWave;
    public int zombieIncrement;
    public GameObject[] zombies;
    public GameObject zombiePrefab;

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
        for (int i = 0; i < currentWave + zombieIncrement; i++) {
            Instantiate(zombiePrefab, new Vector3(0, 0, 0), Quaternion.identity);;
        }
    }
}
