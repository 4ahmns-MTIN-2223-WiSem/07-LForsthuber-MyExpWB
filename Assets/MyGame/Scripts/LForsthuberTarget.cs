using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LForsthuberTarget : MonoBehaviour
{
    private LForsthuberManager manager;

    private void Awake()
    {
        manager = FindObjectOfType<LForsthuberManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (tag == "target")
        {
            manager.winCanvas.SetActive(true);
            Debug.Log("oha, there is the target, yay!");
        }
    }
}
