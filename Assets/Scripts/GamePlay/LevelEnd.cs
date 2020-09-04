using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine.Editor;
using Cinemachine;

public class LevelEnd : MonoBehaviour
{
    [SerializeField]
    GameObject Camera, Player, Portal, CameraRotate, Ui;


    // Start is called before the first frame update
    void Start()
    {
        //TrapsController.die += 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Finish()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        var player = other.gameObject.GetComponent<PlayerController>();

        if (player == null)
            return;

        Player.SetActive(false);

        Camera.SetActive(false);

        CameraRotate.SetActive(true);

        Ui.gameObject.SetActive(true);
    }

}
