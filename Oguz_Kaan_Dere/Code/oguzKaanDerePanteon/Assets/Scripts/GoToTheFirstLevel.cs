using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToTheFirstLevel : MonoBehaviour
{
    [SerializeField] GameObject TapToStartScreen;
    [SerializeField] GameObject BtnToHome;

    private void Start()
    {
        Button btn = BtnToHome.GetComponent<Button>();
        btn.onClick.AddListener(GoToTheFirstLevelFunc);
    }

    void Update()
    {
        if ((Input.touchCount > 0 || Input.GetMouseButtonDown(0)) && TapToStartScreen.activeSelf)
        {
            TapToStartScreen.SetActive(false);
        }
    }

    void GoToTheFirstLevelFunc()
    {
        SceneManager.LoadScene("Level1");
    }
    }
