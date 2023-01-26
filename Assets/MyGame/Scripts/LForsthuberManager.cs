using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class LForsthuberManager : MonoBehaviour
{
    public int myLevel = 1;
    public GameObject target;
    public Transform pos1, pos2, pos3;
    public GameObject tree1, tree2, tree3;
    public Transform t1Pos, t2Pos, t3Pos;
    public GameObject startPos;
    public TMP_Text distanceText;
    public TMP_Text levelText;

    private float startDistance;
    private float throwDistance;

    void Start()
    {
        if (myLevel == 1)
        {
            target.transform.position = pos1.position;
        }

        startDistance = Vector3.Distance(startPos.transform.position, tree3.transform.position);
        Debug.Log(startDistance);
    }

    void Update()
    {
        throwDistance = Vector3.Distance(startPos.transform.position, tree3.transform.position);
        double shortNumberDistance = Math.Round(throwDistance, 2);

        distanceText.text = shortNumberDistance.ToString();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myLevel++;
            if (myLevel==2)
            {
                target.transform.position = pos2.position;
            }

            if (myLevel == 3)
            {
                target.transform.position = pos3.position;
            }

            Debug.Log("levelwechsel");

            tree1.transform.position = t1Pos.position;
            tree2.transform.position = t2Pos.position;
            tree3.transform.position = t3Pos.position;

            levelText.text = "LEVEL " + myLevel;
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
