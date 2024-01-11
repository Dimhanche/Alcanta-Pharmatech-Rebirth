using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Casino : MonoBehaviour
{

    [SerializeField]private GameObject casino;
    [SerializeField]private List<string> possible = new List<string> {/*0*/ "rien", "rien", "rien", "rien", "rien", "rien",/*6*/"petit", "petit",/*8*/"grand",/*9*/ "moyen",/*10*/ "vie" };
    [SerializeField]private string result1,result2,result3;
    [SerializeField]private Text res1, res2, res3;
    Money money;
    private void Start()
    {
        money = gameObject.GetComponent<Money>();
        
    }
    public void OpenCasino()
    {
        casino.SetActive(true);
        Time.timeScale = 0;
        res1.text = "";
        res2.text = "";
        res3.text = "";
    }
    public void CloseCasino()
    {
        casino.SetActive(false);
        Time.timeScale = 1;
    }
    public void Play()
    {
        if(money.GetMoney() >=1000)
        {
            money.Remove(1000);
            result1 = ChooseLot();
            result2 = ChooseLot();
            result3 = ChooseLot();
            res1.text = result1;
            res2.text = result2;
            res3.text = result3;
            if (result1 == result2 && result3 == result1)
            {
                Win(result1);
            }
            else
            {
                res2.text = "Perdu";
            }
        }
    }
    void Win(string lot)
    {
        switch (lot)
        {
            case "petit":
                money.Add(500);
                break;
            case "moyen":
                money.Add(999);
                break;
            case "grand":
                money.Add(1500);
                break;
            case "vie":
                GameObject.Find("MenuManager").GetComponent<MenuManager>().AddLife();
                break;
            default:
                res2.text = "Perdu";
                break;
        }
    }
    private string ChooseLot()
    {
        string loot;
        switch (Random.Range(0, possible.Count+1))
        {
            case <=5:
                loot ="";
                break;
            case <=7:
                loot = "¤";
                break;
            case 8:
                loot = "¤¤";
                break;
            case 9:
                loot = "¤¤¤";
                break;
            case 11:
                loot = possible[10];
                break;
            default:
                loot ="";
                break;
        }
        return loot;
    }
}
