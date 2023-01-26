using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LForsthuberTarget : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (tag == "target")
        {
            Debug.Log("oha, there is the target, yay!");
        }
    }
}
