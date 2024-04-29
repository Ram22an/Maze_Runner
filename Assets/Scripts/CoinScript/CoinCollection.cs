using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GamePlayController.instanceOfGamePlay.CoinCollected();
            SoundScripts.Instance.CoinCollectSound();
            gameObject.SetActive(false);
        }

    }



}//class
