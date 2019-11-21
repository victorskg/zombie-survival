using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
    private Animator animator;
    private Transform player;
    public PlayerLife playerLife;
    private Rigidbody2D myRigidbody;

    void Start()
    {
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        float limite = 1.2f;
        Vector3 aproximando = (Vector2)player.position - myRigidbody.position;
        if (Mathf.Abs(aproximando.x) >= limite || Mathf.Abs(aproximando.y) >= limite)
        {
            animator.SetBool("attack", false);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            animator.SetBool("attack", true);
            playerLife.sofrerDano();
        }
    }
}
