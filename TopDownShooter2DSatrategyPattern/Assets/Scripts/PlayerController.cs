using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;

    float moviment;
    Vector3 mousePosition;
    Quaternion Rotation;
    Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Rotation = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);

        transform.rotation = Rotation;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z) ;

        moviment = Input.GetAxis("Vertical");
        rb2d.AddForce(gameObject.transform.up * moviment * speed);

    }
}
