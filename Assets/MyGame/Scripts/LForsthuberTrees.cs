using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LForsthuberTrees : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;

    //public float thrust = 5f;
    //public Rigidbody treeRb;

    //void Start()
    //{
    //    treeRb = GetComponent<Rigidbody>()
    //}

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }

    //private void OnMouseUp()
    //{
    //    treeRb.AddForce(0, 0, thrust, ForceMode.Force);
    //}


}
