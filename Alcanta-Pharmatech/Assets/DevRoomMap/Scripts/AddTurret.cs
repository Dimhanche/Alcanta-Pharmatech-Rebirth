using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTurret : MonoBehaviour
{
    public GameObject Lame, Blaster, Canon, positionSelect;
    public void BuyLame()
    {
        Instantiate(Lame, positionSelect.transform.position, Quaternion.identity);
        Debug.Log("lame acheter");
        CloseWindow();
    }
    public void BuyBlaster()
    {
        Instantiate(Blaster,positionSelect.transform.position,Quaternion.identity);
        Debug.Log("blaster acheter");
        CloseWindow();
    }
    public void BuyCanon()
    {
        Instantiate(Canon, positionSelect.transform.position, Quaternion.identity);
        Debug.Log("canon acheter");
        CloseWindow();
    }
    void CloseWindow()
    {
        this.gameObject.SetActive(false);
        positionSelect.SetActive(false);
    }
}
