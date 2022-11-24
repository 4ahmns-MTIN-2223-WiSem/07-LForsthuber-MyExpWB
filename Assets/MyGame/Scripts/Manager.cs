using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("oha, there is the target, yay!");
    }


    /*
     * man kann nicht ¸ber die Startlinie
     * Spiel beginnt wenn man Startlinie betritt
     * pro Versuch kann nur ein Baum genommen werden
     * messen der Wurfweite
     * sehen ob die Zielscheibe getroffe wurde
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
