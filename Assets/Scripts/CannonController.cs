using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{

    [SerializeField]
    GameObject Player;

    [SerializeField]
    Transform Head;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        var player = other.attachedRigidbody.GetComponent<PlayerController>();

        if (player == null)
            return;
        if(player)
        Debug.Log(1);

        if (Input.GetKeyDown(KeyCode.F))
        {
            var pl = Player.transform.position;
            pl = Head.position;

            /*var rigid = Player.gameObject.GetComponent<Rigidbody>();
            rigid.constraints = RigidbodyConstraints.FreezeAll;*/
        }
    }
}
