using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTurret : MonoBehaviour
{
    public GameObject Lame, Blaster, Canon, positionSelect;
    [SerializeField] private int priceLame,priceBlaster,priceCanon;
    [SerializeField] private Money money;
    public void BuyLame()
    {
        if(money.GetMoney() >= priceLame)
        {
            Instantiate(Lame, positionSelect.transform.position, Quaternion.identity);
            money.Remove(priceLame);
            CloseWindow();
        }
    }
    public void BuyBlaster()
    {
        if(money.GetMoney() >= priceBlaster)
        {
            Instantiate(Blaster, positionSelect.transform.position, Quaternion.identity);
            money.Remove(priceBlaster);
            CloseWindow();
        }
    }
    public void BuyCanon()
    {
        if(money.GetMoney() >= priceCanon)
        {
            Instantiate(Canon, positionSelect.transform.position, Quaternion.identity);
            money.Remove(priceCanon);
            CloseWindow();
        }
    }
    void CloseWindow()
    {
        this.gameObject.SetActive(false);
        positionSelect.SetActive(false);
    }
}
