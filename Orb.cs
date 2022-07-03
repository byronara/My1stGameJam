using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player" && other.gameObject.GetComponent<Controller_Script>().CurrentHP == other.gameObject.GetComponent<Controller_Script>().MaxHP)
        {
            other.gameObject.GetComponent<Controller_Script>().MaxHP++;
        }
    }
}
