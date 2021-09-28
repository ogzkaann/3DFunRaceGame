using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");

        if (other.gameObject.CompareTag("Player"))
        {
            camera.transform.SetParent(null);
            Destroy(other.gameObject);
            GameObject myPlayer = Instantiate(Resources.Load("Player"), Vector3.zero, Quaternion.identity) as GameObject;
            camera.transform.parent = myPlayer.transform;
        } else if (other.gameObject.CompareTag("Enemy") && GameObject.FindGameObjectsWithTag("Enemy").Length < 11)
        {
            Destroy(other.gameObject);
            GameObject myPlayer = Instantiate(Resources.Load("Girl"), Vector3.zero, Quaternion.identity) as GameObject;
        }
            
    }
}
