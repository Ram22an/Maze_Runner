using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonScripts : MonoBehaviour
{
    public GameObject cameraObject;
    private Animator cameraAnimator;
    public Canvas canvasUI;
    public GameObject canvasGO;
    private void Awake()
    {
        cameraObject = GameObject.FindGameObjectWithTag("MainCamera");
        canvasGO = GameObject.Find("Canvas");
        // Get the Canvas component attached to the GameObject
        canvasUI = canvasGO.GetComponent<Canvas>();
        cameraAnimator = cameraObject.GetComponent<Animator>();
    }
    public void StartButton()
    {
        canvasUI.enabled = false;
        cameraAnimator.SetInteger("Play",1);
    }
    public void AboutButton()
    {
        canvasUI.enabled = false;
        cameraAnimator.SetInteger("Play",2);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    
}
