using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetButton : MonoBehaviour
{
    [SerializeField]private int price;
    [SerializeField]private Text textPrice;
    [SerializeField]private Money money;

    // Update is called once per frame
    void Update()
    {
        if(money.GetMoney() >= price)
        {
            this.gameObject.GetComponent<Button>().enabled = true;
            textPrice.text = "Acheter :"+price;
        }
        else
        {
            this.gameObject.GetComponent<Button>().enabled = false;
            textPrice.text = "Pas Assez D'argent";
        }
    }
}
