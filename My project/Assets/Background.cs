using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel;
    void Start()
    {
        vel = 4;
        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0,-vel);
    }

    void Update()
    {
        if(transform.position.y < -Camera.main.orthographicSize){
            Destroy(gameObject);
        }
    }
}
