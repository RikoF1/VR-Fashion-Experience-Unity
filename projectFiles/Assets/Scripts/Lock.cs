using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    [SerializeField] GameObject Chest;
    [SerializeField] GameObject Key;

    private bool locked;
    // Start is called before the first frame update
    void Start()
    {
        locked = true;
        Chest.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key" && locked)
        {
            UnlockChest();
        }
    }

    private void UnlockChest()
    {
        Chest.GetComponent<Rigidbody>().isKinematic = false;
        this.GetComponent<Rigidbody>().isKinematic = false;
        this.GetComponent<BoxCollider>().isTrigger = false; // makes lock not fall down the floor
        locked = false;
    }
}
