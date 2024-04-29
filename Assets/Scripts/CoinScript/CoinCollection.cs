using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GamePlayController.instanceOfGamePlay.CoinCollected();
            SoundScripts.Instance.CoinCollectSound();
            StartCoroutine(CoinCollected());
        }

    }
    IEnumerator CoinCollected()
    {
        yield return new WaitForSeconds(0f);
        gameObject.SetActive(false);
    }
    /***
    {
          
    }
    ***/
}
