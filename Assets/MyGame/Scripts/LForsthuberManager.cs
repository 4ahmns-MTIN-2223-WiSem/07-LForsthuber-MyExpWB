using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class LForsthuberManager : MonoBehaviour
{
    private int myLevel = 1;
    public GameObject target;
    public Transform pos1, pos2, pos3;
    public GameObject tree1, tree2, tree3;
    public Transform t1Pos, t2Pos, t3Pos;
    public GameObject startPos;
    public TMP_Text distanceText, levelText, tryText;
    public int nbrTrys;
    public GameObject endCanvas;
    public GameObject winCanvas;

    public float startDistance;
    private float throwDistance;

    private LForsthuberTrees mytree1, mytree2, mytree3;
    private LForsthuberTrees states;

    private void Awake()
    {
        nbrTrys = 3;

    }
    void Start()
    {
        endCanvas.SetActive(false);
        winCanvas.SetActive(false);
        states = FindObjectOfType<LForsthuberTrees>();

        mytree1 = tree1.GetComponent<LForsthuberTrees>();
        mytree2 = tree2.GetComponent<LForsthuberTrees>();
        mytree3 = tree3.GetComponent<LForsthuberTrees>();

        if (myLevel == 1)
        {
            target.transform.position = pos1.position;
        }

    }

    void Update()
    {
        Debug.Log(mytree1.myState);

        if (mytree1.myState == TreeState.idle)
        {
            distanceText.text = startDistance.ToString();
        }
        if (mytree1.myState == TreeState.thrown)
        {
            throwDistance = Vector3.Distance(startPos.transform.position, tree3.transform.position);
            double shortNumberDistance = Math.Round(throwDistance, 2);
            distanceText.text = shortNumberDistance.ToString();
        }

        if (mytree2.myState == TreeState.idle)
        {
            distanceText.text = startDistance.ToString();
        }
        if (mytree2.myState == TreeState.thrown)
        {
            throwDistance = Vector3.Distance(startPos.transform.position, tree3.transform.position);
            double shortNumberDistance = Math.Round(throwDistance, 2);
            distanceText.text = shortNumberDistance.ToString();
        }

        if (mytree3.myState == TreeState.idle)
        {
            distanceText.text = startDistance.ToString();
        }
        if (mytree3.myState == TreeState.thrown)
        {
            throwDistance = Vector3.Distance(startPos.transform.position, tree3.transform.position);
            double shortNumberDistance = Math.Round(throwDistance, 2);
            distanceText.text = shortNumberDistance.ToString();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myLevel++;
            if (myLevel == 2)
            {
                target.transform.position = pos2.position;
            }

            if (myLevel == 3)
            {
                target.transform.position = pos3.position;
            }

            nbrTrys = 3;

            distanceText.text = startDistance.ToString();

            tree1.transform.position = t1Pos.position;
            tree2.transform.position = t2Pos.position;
            tree3.transform.position = t3Pos.position;

            tree1.transform.rotation = t1Pos.rotation;
            tree2.transform.rotation = t2Pos.rotation;
            tree3.transform.rotation = t3Pos.rotation;

            levelText.text = "LEVEL " + myLevel;

            winCanvas.SetActive(false);
        }

        if (nbrTrys == 0)
        {
            endCanvas.SetActive(true);
        }
    }

    /*
     * man kann nicht ¸ber die Startlinie
     * Spiel beginnt wenn man Startlinie betritt
     * pro Versuch kann nur ein Baum genommen werden
     * messen der Wurfweite
     * Physics f¸r B‰ume
     * Toneffekte: ->  Baumaufprall (Boden und Zielscheibe), 
     *             ->  Weihnachtslied f¸r Hintergrund
     *             ->  Ausreiﬂen der B‰ume
     * 
     * Enum: weiﬂ noch nicht
     * Methodendeklaration/-aufruf: Braucht man immer
     * If-Statement: z.B. hat der Baum die Zielscheibe getroffen ja/nein
     */
}
