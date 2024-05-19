using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraScript : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene("LevelsChoose");
    }
    public void AboutLevel()
    {
        SceneManager.LoadScene("AboutLevel");
    }
    public void UILevel()
    {
        SceneManager.LoadScene("UIStarting");
    }
}
