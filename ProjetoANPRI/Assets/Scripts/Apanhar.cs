using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apanhar : MonoBehaviour
{
    public Collider Player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player")) {
            transform.parent = other.transform;
            Player = other;
            Player.gameObject.tag = "PlayerComOvo";
        } else if (other.gameObject.tag.Equals("Entrega")) {
            transform.parent = other.transform;
            Player.gameObject.tag = "Player";
        }
    }
}
