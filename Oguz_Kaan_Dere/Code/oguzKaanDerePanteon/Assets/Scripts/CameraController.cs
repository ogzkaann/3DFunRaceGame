using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject player;
    void Start()
    {
        this.transform.parent = player.transform;
    }
}
