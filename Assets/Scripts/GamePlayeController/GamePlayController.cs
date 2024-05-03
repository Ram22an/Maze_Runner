using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour
{
    public static GamePlayController instanceOfGamePlay;
    private TextMeshProUGUI CoinText,HealthText;
    private int CoinScore;
    [HideInInspector]
    public bool IsPlayerAlive;
    public GameObject EndPanel;
    // Start is called before the first frame update
    void Awake()
    {
        MakeInstance();
        CoinText = GameObject.Find("CoinText").GetComponent<TextMeshProUGUI>();
        HealthText = GameObject.Find("HealthText").GetComponent<TextMeshProUGUI>();
        CoinText.text = "Coin: "+CoinScore;
        EndPanel = GameObject.Find("GameOverPanel");
    }

    // Update is called once per frame
    void Start()
    {
        IsPlayerAlive=true;
        EndPanel.SetActive(false);
    }
    void MakeInstance()
    {
        if (instanceOfGamePlay == null)
        {
            instanceOfGamePlay = this;
        }
        else if (instanceOfGamePlay != null)
        {
            Destroy(instanceOfGamePlay);
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

    public void GameOver()
    {
        SoundScripts.Instance.StopBackgroundMusic();
        Time.timeScale = 0f;
        EndPanel.SetActive(true);
    }






}//class
