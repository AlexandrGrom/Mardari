using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    [SerializeField] private Button button;
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameStateManager.currentState = EStates.None;
    }

    private void Update()
    {
        if (GameStateManager.currentState == EStates.Lose)
        {
            button.gameObject.SetActive(true);

            ColorBlock cb = button.colors;
            cb.normalColor = Color.red;
            button.colors = cb;
        }

        if (GameStateManager.currentState == EStates.Win)
        {
            button.gameObject.SetActive(true);

            ColorBlock cb = button.colors;
            cb.normalColor = Color.blue;
            button.colors = cb;
        }
    }


}
