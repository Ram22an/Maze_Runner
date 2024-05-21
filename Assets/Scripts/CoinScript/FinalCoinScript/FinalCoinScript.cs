using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalCoinScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Player")
        {
            int sceneCount = SceneManager.GetActiveScene().buildIndex;
            if (sceneCount+1 == 8)
            {
                SceneManager.LoadScene(3);
            }
            else
            {
                SceneManager.LoadScene(sceneCount + 1);
            }
        }
    }
}
