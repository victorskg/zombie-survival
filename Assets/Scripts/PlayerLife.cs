using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    private int hp = 100;
    private int dano = 10;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public int sofrerDano()
    {
        if(dano <= hp)
        {
            hp -= dano;
            return hp;
        }
        return 0;
    }

    public int getHp()
    {
        return hp;
    }

    public int getDano()
    {
        return dano;
    }
}
