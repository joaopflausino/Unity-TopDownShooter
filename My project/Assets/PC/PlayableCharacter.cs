using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayableCharacter : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rbd;
    private float vel;
    private float altura;
    private float largura;
    void Start()
    {
        rbd = this.GetComponent<Rigidbody2D>();
        vel = 10;

        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rbd.velocity = new Vector2(x,y) * vel;

        if(transform.position.x > largura - 1.5){
            transform.position = new Vector2(largura - 1.5f,transform.position.y);
        }else if (transform.position.x < -largura + 1.5f){
            transform.position = new Vector2(-largura + 1.5f,transform.position.y);
        }

        if(transform.position.y > 5){
            transform.position = new Vector2(transform.position.x,5);
        }else if(transform.position.y < -4.5f){
            transform.position = new Vector2(transform.position.x,-4.5f);
        }
    }
}
