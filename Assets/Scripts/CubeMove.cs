using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    private GameObject _cubeObject;
    public Rigidbody2D rb;
    public float speedforce;
    public float x;
    public float y;
    private bool _moveDone;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        x = Random.Range(-100, 100);
        y = Random.Range(-100, 100);
        speedforce = Random.Range(1, 30);
    }

    void Update()
    {
        ThrowCube();
    }

    //nadanie ruch kostką w momencie "spacji", gdy ruch nie został jeszcze wcześniej wykonany
    void ThrowCube()
    {
        if(Input.GetKey("space") && !_moveDone)
        {
            Vector2 direction = new Vector2(x, y);
            rb.AddForce(direction * speedforce);
            _moveDone = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
       if(other.CompareTag("cube"))
       {
        Destroy(gameObject);
       } 
    }

    void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }
}
