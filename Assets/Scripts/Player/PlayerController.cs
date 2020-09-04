using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerController : MonoBehaviour
{
    public float Speed, StartSpeed;

    [SerializeField]
    private float JumpHeigh;

    [SerializeField]
    private Rigidbody rigidbody;

    [SerializeField]
    SphereCollider sphere;

    [SerializeField]
    LayerMask mask;

    public bool isRunning = false;

    [SerializeField]
    Text speedDisplayer;
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rigidbody.AddForce(Vector3.up * JumpHeigh, ForceMode.Impulse);
            Debug.Log("JUMP");
        }

    }
    private void FixedUpdate()
    {
        //speedDisplayer.text = Speed.ToString();

        var horMovement = Input.GetAxis("Horizontal") * Speed;
        var verMovement = Input.GetAxis("Vertical") * Speed;
        var jump = Input.GetAxis("Jump") * JumpHeigh;

        Vector3 move = new Vector3(horMovement, 0, verMovement);
        rigidbody.AddForce(move);

    }


    private bool IsGrounded()
    {
        return Physics.CheckCapsule(sphere.bounds.center, new Vector3(sphere.bounds.center.x, sphere.bounds.min.y,
            sphere.bounds.center.z), sphere.radius * 1.2f, mask);
    }

    private void OnCollisionEnter(Collision other)
    {
        var ramp = other.gameObject.GetComponent<SpeedUpController>();

        if (ramp == null)
            return;

        //Speed += (float)ramp.speedUp;
        rigidbody.AddForce(Vector3.forward * (float)ramp.speedUp, ForceMode.Impulse);
        Debug.Log(ramp.speedUp);
    }

    
}
