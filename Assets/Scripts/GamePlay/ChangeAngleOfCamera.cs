using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine.Editor;
using Cinemachine;

public class ChangeAngleOfCamera : MonoBehaviour
{
    [SerializeField]
    float rotationMeaning;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider coll)
    {
        var collider = coll.gameObject.GetComponent<PlayerController>();
        if (collider == null)
            return;


        var rotations = collider.transform.rotation;
        rotations *= new Quaternion(0, rotationMeaning, 0, 0);
    }
}
