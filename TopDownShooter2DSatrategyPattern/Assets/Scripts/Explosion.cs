using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    Animator Anim;
    void Start()
    {
        Anim = GetComponent<Animator>();
        Invoke("Die", Mathf.CeilToInt(Anim.GetCurrentAnimatorStateInfo(0).length));
    }

    void Die()
    {
        Destroy(gameObject);
    }
}

