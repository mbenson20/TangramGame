using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayLevel(int levelNum)
    {
        SceneManager.LoadScene(levelNum + 1);
    }
}
