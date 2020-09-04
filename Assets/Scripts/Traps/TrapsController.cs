using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class TrapsController : MonoBehaviour
{
    public static event Action die;

    [SerializeField]
    GameObject Player;

    [SerializeField]
    GameObject destroy;

    private void OnCollisionEnter(Collision other)
    {

        var play = other.gameObject.GetComponent<PlayerController>();

        if (play == null)
            return;

        die.Invoke();
        Player.SetActive(false);  
    }
}
