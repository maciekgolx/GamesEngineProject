using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject Player;
    public GameObject TeleportEnd;
    public GameObject TeleportStart;
    private void OnTriggerEnter(Collider collisins) {
        if(collisins.gameObject.CompareTag("Teleporter")){
            Player.transform.position = TeleportEnd.transform.position;
        }
        if(collisins.gameObject.CompareTag("2Teleporter")){
            Player.transform.position = TeleportStart.transform.position;
        }
    }
}
