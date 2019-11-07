using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroSimples : Arma, IArma
{
    [SerializeField] float speed;
    private Transform firePoint;

    void Start()
    {
        firePoint = GetComponent<Transform>().GetChild(0);
    }

    public void Atirar()
    {
        GameObject Bullet = Instantiate(Resources.Load("Bullet", typeof(GameObject))) as GameObject;
        Bullet.transform.position = firePoint.position;
        Bullet.transform.rotation = firePoint.rotation;
        Bullet.GetComponent<Rigidbody2D>().velocity = transform.up * speed;

    }
}
