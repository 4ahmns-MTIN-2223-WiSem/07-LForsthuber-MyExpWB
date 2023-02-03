using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum TreeState
{
    idle,
    pickUp,
    thrown
}

public class LForsthuberTrees : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;

    private LForsthuberManager manager;

    public TreeState myState;

    private void Awake()
    {
        myState = TreeState.idle;
        manager = FindObjectOfType<LForsthuberManager>();
    }

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();

        manager.startDistance = 0f;
        myState = TreeState.pickUp;

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

    private void OnMouseUp()
    {
        myState = TreeState.thrown;
        manager.nbrTrys--;
        manager.tryText.text = "VERSUCHE: " + manager.nbrTrys;
        
    }
}
