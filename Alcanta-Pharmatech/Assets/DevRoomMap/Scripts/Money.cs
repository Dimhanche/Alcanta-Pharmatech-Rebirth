using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    [SerializeField] private Text argentTxt;
    [SerializeField] public int argent;
    private void Start()
    {
        UpdateMoney();
    }
    public void Add(int amount)
    {
        argent += amount;
        UpdateMoney();
    }

    public void Remove(int amount)
    {
        argent -= amount;
        UpdateMoney();
    }
    private void UpdateMoney()
    {
        argentTxt.text = argent.ToString();
    }
    public int GetMoney()
    {
        return argent;
    }
}
