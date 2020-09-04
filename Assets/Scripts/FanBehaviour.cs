using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision other)
    {
        var player = other.gameObject.GetComponent<PlayerController>();

        if (player == null)
            return;

        var rigid = player.GetComponent<Rigidbody>();

        rigid.useGravity = false;
        rigid.AddForce(0, 1, 0);
    }

    private void OnCollisionExit(Collision other)
    {
        var player = other.gameObject.GetComponent<PlayerController>();

        if (player == null)
            return;

        var rigid = player.GetComponent<Rigidbody>();

        rigid.useGravity = true;
    }
}
