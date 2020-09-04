using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    public float RotationSpeed;
    public Transform player, target;
    public float MouseX, MouseY;

    Vector3 offset;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        //offset = transform.position - player.transform.position;
    }
    private void Update()
    {
        target.transform.rotation = new Quaternion(0, 0, 0, 0);
        target.transform.position = player.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //CamControll();
    }

}
