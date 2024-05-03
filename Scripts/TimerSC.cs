using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerSC : MonoBehaviour
{
    [SerializeField] private TMP_Text zaman_T;
    public static float zaman;

    private void Start()
    {
        zaman = 0;
        zaman_T.text = " " + (int) zaman;
    }
    private void Update()
    {
        zaman += Time.deltaTime;
        zaman_T.text = " Sure : " + (int)zaman;
    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
