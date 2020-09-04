using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingAway : MonoBehaviour
{
    public
    Transform spawnPosition;

    [SerializeField]
    Transform playerPosition;

    [SerializeField]
    GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        var play = other.gameObject.GetComponent<PlayerController>();

        if (play == null)
            return;


        playerPosition.position = spawnPosition.position;

        var rg = Player.GetComponent<Rigidbody>();
        rg.velocity = new Vector3(0,0,0);
    }
}
