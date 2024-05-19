using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoingBack : MonoBehaviour
{
    public GameObject canvasGO;
    public GameObject cameraObject;
    private Animator cameraAnimator;
    private void Awake()
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

    }
    public void Level2()
    {

    }
    public void Level3()
    {

    }
    public void Level4()
    {

    }
    public void Level5()
    {

    }
}
