using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    void OnTriggerEnter (Collider other) {
        if (other.gameObject.tag == "Player") 
        {
        this.GetComponent<AudioSource>().Play(); 
        }
        else 
        {

        }
 }

 void OnTriggerExit (Collider other) {
     if (other.gameObject.tag == "Player")
     {
      this.GetComponent<AudioSource>().Stop();
     }
     else
     {

     }
 } 
}
