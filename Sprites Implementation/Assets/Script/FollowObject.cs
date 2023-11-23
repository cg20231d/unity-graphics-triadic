using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform target; // Objek yang ingin dilihat kamera

    void Update()
    {
        // Pastikan objek target telah diatur sebelum mencoba mengatur rotasi kamera
        if (target != null)
        {
            // Atur rotasi kamera untuk melihat ke objek target
            transform.LookAt(target);
        }
    }
}
