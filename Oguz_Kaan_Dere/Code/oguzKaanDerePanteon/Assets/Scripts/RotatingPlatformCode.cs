using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatformCode : MonoBehaviour
{

    void Update()
    {
        this.transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime);
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    //Debug.Log("Karakter İçerde");
    //    //other.transform.parent = transform;
    //    //other.gameObject.localRotation = this.transform.localRotation;

    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    //Debug.Log("Karakter Çıktı");
    //    //other.transform.parent = null;
    //    //other.gameObject.localRotation = this.transform.localRotation;

    //}
}
