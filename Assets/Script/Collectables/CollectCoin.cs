using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;

    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();//play the sfx
        CollectControl.scoreCount += 1;//add score
        this.gameObject.SetActive(false);//hide the object
    }
}
