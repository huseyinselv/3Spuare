using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenuSX : MonoBehaviour
{
   public void TryAgain()
    {
        SceneManager.LoadScene("Level1");
        Destroy(GameObject.Find("KALICI"));
    }
    public void BacaktoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }




}
