using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTurret : MonoBehaviour
{
    public GameObject Lame, Blaster, Canon, positionSelect;
    public void BuyLame()
    {
        //buy Lame
        Debug.Log("lame acheter");
        CloseWindow();
    }
    public void BuyBlaster()
    {
        Instantiate(Blaster,positionSelect.transform.position,Quaternion.identity);
        Debug.Log("blaster acheter");
        CloseWindow();
        positionSelect.SetActive(false);
    }
    public void BuyCanon()
    {
        //buy canon
        Debug.Log("canon acheter");
        CloseWindow();
    }
    void CloseWindow()
    {
        this.gameObject.SetActive(false);
    }
}
