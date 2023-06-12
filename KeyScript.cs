using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameObject other;
    public GameObject destroy;
    public GameObject anotherdestroy;

    public void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.F))
        {
            Destroy(destroy);
            Destroy(anotherdestroy);
            print("destroyed");
        }
    }

}
