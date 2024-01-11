using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]private int vie = 3;

    public void LooseLife()
    {
        if (vie > 0)
        {
            vie--;
        }
        if(vie <=0)
        {
            Loose();
        }
    }
    private void Loose()
    {
        Debug.Log("loose");
        //Affiche menu fin
    }
}
