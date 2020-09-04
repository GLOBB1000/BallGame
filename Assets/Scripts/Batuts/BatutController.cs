using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatutController : MonoBehaviour
{
    public BatutJumpHeigh batut;
    [SerializeField]
    PlayerController player;

    [SerializeField]
    Rigidbody rigidbody;

    private void OnCollisionEnter(Collision other)
    {
        var Player = other.gameObject.GetComponent<PlayerController>();

        if (Player == null)
            return;

        rigidbody.velocity = Vector3.up * (float)batut;
    }
}
