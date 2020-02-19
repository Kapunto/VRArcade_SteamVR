using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WallDetecter : MonoBehaviour
{
    public UnityEvent WallHit;

    private void Start()
    {
        if (WallHit == null)
            WallHit = new UnityEvent();
    }

    private void OnTriggerEnter(Collider hitInfo)
    {
        WallHit.Invoke();
      
    }
}
