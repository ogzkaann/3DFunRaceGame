using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishingCode : MonoBehaviour
{
    [SerializeField] GameObject camera;
    [SerializeField] GameObject confetti;
    [SerializeField] GameObject GameOverScreen;

    private void Start()
    {
        GameOverScreen = GameObject.FindGameObjectWithTag("gameover");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            camera.GetComponent<Animator>().SetBool("finishCamera", true);
            other.GetComponent<Animator>().SetBool("Dance", true);
            other.GetComponent<playerController>().enabled = false;
            confetti.SetActive(true);
            StartCoroutine(waiter());
        }
        
        else if (other.gameObject.tag == "Enemy") 
        {
            //ui'dan üstte Game Over ve altta da Tap to Play Again yazan ekran gelecek.
            other.GetComponent<playerController>().enabled = false;
            GameOverScreen.SetActive(true);
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Level2");
    }
}
