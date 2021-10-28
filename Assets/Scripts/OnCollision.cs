using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnCollision : MonoBehaviour
{
    public GameObject MiniPotassium;
    public AudioSource exp1Audio;
    

 
    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "WaterLiquid")
        {
            Destroy(this.gameObject);
            MiniPotassium.active = true;
            exp1Audio.enabled = true;

         

        }
    }
}
