using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseRotatingPlatformCode : MonoBehaviour
{
    void Update()
    {
        this.transform.Rotate(new Vector3(0, 0, -90) * Time.deltaTime);
    }
    //private void OnTriggerStay(Collider other)
    //{
    //    Debug.Log("Karakter İçerde");
    //    other.gameObject.transform.parent = this.transform;
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    Debug.Log("Karakter Çıktı");
    //    other.gameObject.transform.parent = null;
    //}
}
