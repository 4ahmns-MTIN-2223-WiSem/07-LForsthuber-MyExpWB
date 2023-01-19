using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauraManager : MonoBehaviour
{
    public int myLevel = 1;
    public GameObject target;
    public Transform pos1, pos2, pos3;
    public GameObject tree1, tree2, tree3;
    public Transform t1pos, t2pos, t3pos;

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

            if (myLevel == 3)
            {
                target.transform.position = pos3.position;
            }

            Debug.Log("levelwechsel");

            tree1.transform.position = t1pos.position;
            tree2.transform.position = t2pos.position;
            tree3.transform.position = t3pos.position;
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
