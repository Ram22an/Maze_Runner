using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ButtonScripts : MonoBehaviour
{
    public GameObject cameraObject;
    private Animator cameraAnimator;
    public Camera myCamera;
    public Canvas canvasUI;
    public GameObject canvasGO;
    private void Awake()
    {
        cameraObject = GameObject.FindGameObjectWithTag("MainCamera");
        myCamera = Camera.main;
        canvasGO = GameObject.Find("Canvas");
        // Get the Canvas component attached to the GameObject
        canvasUI = canvasGO.GetComponent<Canvas>();
        cameraAnimator = cameraObject.GetComponent<Animator>();
    }
    public void StartButton()
    {
        canvasUI.enabled = false;
    }
    public void AboutButton()
    {
        canvasUI.enabled = false;
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
