using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int myLevel = 1;
    public GameObject target;
    public Transform pos1, pos2, pos3;

    void Start()
    {
        if (myLevel == 1)
        {
            target.transform.position = pos1.position;
        }
    }

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            myLevel++;
            if (myLevel==2)
            {
                target.transform.position = pos2.position;
            }

            Debug.Log("levelwechsel");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (tag=="tree")
        {
            Debug.Log("oha, there is the target, yay!");
        }
    }


    /*
     * man kann nicht ¸ber die Startlinie
     * Spiel beginnt wenn man Startlinie betritt
     * pro Versuch kann nur ein Baum genommen werden
     * messen der Wurfweite
     * sehen ob die Zielscheibe getroffen wurde
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
