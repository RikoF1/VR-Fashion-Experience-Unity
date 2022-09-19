using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonOptions : MonoBehaviour
{
    public void PlayGame () {
        SceneManager.LoadScene (1);
    }

    public void QuitExperience () {
        SceneManager.LoadScene (0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
        SceneManager.LoadScene (0); 
        }
        else 
        {

        }
    }
}
