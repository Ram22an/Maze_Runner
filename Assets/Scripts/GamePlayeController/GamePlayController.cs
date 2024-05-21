using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlayController : MonoBehaviour
{
    public static GamePlayController instanceOfGamePlay;
    private TextMeshProUGUI CoinText,HealthText;
    private int CoinScore;
    public Animator DeadPanel;
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
        if (EndPanel == null) Debug.LogWarning("EndPanel is not collected");
        DeadPanel =EndPanel.GetComponent<Animator>();
        if (DeadPanel == null) Debug.LogWarning("Anim is not collected");

    }
    private void Update()
    {
        GameOver();
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
        EndPanel.SetActive(true);
        //SoundScripts.Instance.StopBackgroundMusic();
        if (SoundScripts.Instance.BackGround.volume==0)
        {
            DeadPanel.SetTrigger("DeadPlay");
            StartCoroutine(ShowEndPanelAfterDelay());
        }
    }
    IEnumerator ShowEndPanelAfterDelay()
    {
        yield return new WaitForSeconds(5f);
        Time.timeScale = 0f;// Wait for 2 seconds
         // Set the EndPanel active after the delay
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("LevelsChoose");
    }
    public void PlayeAgain()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }




}//class
