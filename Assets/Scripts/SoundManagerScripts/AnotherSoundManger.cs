using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AnotherSoundManger : MonoBehaviour
{
    public static AnotherSoundManger Instance;
    public AudioSource BackGround;
    void Awake()
    {
        MakeInstance();
        BackGround.Play();

    }
    void MakeInstance()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != null)
        {
            Destroy(Instance);
        }
    }
}
