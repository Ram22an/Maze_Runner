using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoingBack : MonoBehaviour
{
    public GameObject canvasGO;
    public GameObject cameraObject;
    private Animator cameraAnimator;
    private void Start()
    {
        cameraObject = GameObject.FindGameObjectWithTag("MainCamera");
        canvasGO = GameObject.Find("Canvas");
        cameraAnimator = cameraObject.GetComponent<Animator>();
    }
    public void MainUi()
    {
        canvasGO.SetActive(false);
        cameraAnimator.SetInteger("Play", 3);
    }
    public void MainUi2()
    {
        canvasGO.SetActive(false);
        cameraAnimator.SetInteger("Play", 4);
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void Level4()
    {
        SceneManager.LoadScene("Level4");
    }
    public void Level5()
    {
        SceneManager.LoadScene("Level5");
    }
}
