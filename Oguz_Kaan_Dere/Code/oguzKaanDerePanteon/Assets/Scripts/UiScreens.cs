using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiScreens : MonoBehaviour
{
    [SerializeField] Button BtnMultiplayer;

    private void Start()
    {
        BtnMultiplayer.onClick.AddListener(ClickedOnMultiplayer);

    }
    void ClickedOnMultiplayer()
    {
        SceneManager.LoadScene("Level3");
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(3);
        BtnMultiplayer.gameObject.SetActive(false);
    }
}
