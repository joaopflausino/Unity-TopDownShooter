using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerRespawnBackground : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BackgroundSprite;
    public Vector2 bla;
    void Start()
    {
        InvokeRepeating("Respawn",0,2.6f);
    }

    private void Respawn(){
        bla =BackgroundSprite.transform.position;
        Instantiate(BackgroundSprite,new Vector2(0,bla.y + 12.8f),Quaternion.identity);
    }
}
