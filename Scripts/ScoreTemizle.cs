using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        if(PlayerPrefs.GetInt("highScore") != 0 )
        {
            PlayerPrefs.SetInt("highScore", 0);
        }
    }
}
