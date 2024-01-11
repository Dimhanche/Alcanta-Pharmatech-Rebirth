using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casino : MonoBehaviour
{
    [SerializeField] GameObject casino;
    public void OpenCasino()
    {
        casino.SetActive(true);
        Time.timeScale = 0;
    }
    public void CloseCasino()
    {
        casino.SetActive(false);
        Time.timeScale = 1;
    }
}
