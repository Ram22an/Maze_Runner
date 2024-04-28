using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour
{
    public static GamePlayController instance;
    private TextMeshProUGUI CoinText,HealthText;
    private int CoinScore;
    [HideInInspector]
    public bool IsPlayerAlive;
    // Start is called before the first frame update
    void Awake()
    {
        MakeInstance();
        CoinText = GameObject.Find("CoinText").GetComponent<TextMeshProUGUI>();
        HealthText = GameObject.Find("HealthText").GetComponent<TextMeshProUGUI>();
        CoinText.text = "Coin: "+CoinScore;
    }

    // Update is called once per frame
    void Start()
    {
        IsPlayerAlive=true;
    }
    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(instance);
        }
    }

    public void CoinCollected()
    {
        CoinScore++;
        CoinText.text = "Coin: "+CoinScore;
    } 
    public void DisPlayHealth(int health)
    {
        HealthText.text = "Health:" + health;
    }






}//class
