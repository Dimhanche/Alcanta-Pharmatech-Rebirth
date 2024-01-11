using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casino : MonoBehaviour
{

    [SerializeField]private GameObject casino;
    [SerializeField]private List<string> possible = new List<string> {/*0*/ "rien", "rien", "rien", "rien", "rien", "rien",/*6*/"petit", "petit",/*8*/"grand",/*9*/ "moyen",/*10*/ "vie" };
    [SerializeField]private string result1,result2,result3;
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
    public void Play()
    {
        result1 = ChooseLot();
        result2 = ChooseLot();
        result3 = ChooseLot();
        if(result1 == result2&&result3 == result1)
        {
            Win(result1);
        }
        else
        {
            //loose
        }
    }
    void Win(string lot)
    {
        switch (lot)
        {
            case "petit":
                break;
            case "moyen":
                break;
            case "grand":
                break;
            case "vie":
                break;
            default:
                break;
        }
    }
    private string ChooseLot()
    {
        string loot;
        switch (Random.Range(0, possible.Count+1))
        {
            case <=5:
                loot = possible[0];
                break;
            case <=7:
                loot = possible[6];
                break;
            case 8:
                loot = possible[8];
                break;
            case 9:
                loot = possible[9];
                break;
            case 11:
                loot = possible[10];
                break;
            default:
                loot = possible[0];
                break;
        }
        return loot;
    }
}
