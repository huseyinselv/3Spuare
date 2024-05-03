using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
   public void RestarGame()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1.0f;
        Destroy(GameObject.Find("KALICI"));
    }
}
