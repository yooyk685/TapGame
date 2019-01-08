using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float hp = 10.0f;

    public void SufferDamage(float damage)
    {
        hp -= damage;
        print(hp);
        if (hp <= 0)
            Destroy(gameObject);
    }
}
