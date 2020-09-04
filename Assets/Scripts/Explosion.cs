using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField]
    Transform target;

    [SerializeField]
    GameObject boom;

    [SerializeField]
    GameObject parent;

    [SerializeField]
    GameObject Menu;

    private void Start()
    {
        TrapsController.die += destroy;
    }

    private void Update()
    {
        transform.position = target.transform.position;
    }
    private void OnDestroy()
    {
        TrapsController.die -= destroy;
    }

    public void destroy()
    {
        var lastPos = target.transform;
        var booms = Instantiate(boom, lastPos);

        booms.transform.SetParent(parent.transform);

        Menu.SetActive(true);
    }
}
