using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]private float vitesse;
    [SerializeField]public List<GameObject> movements = new List<GameObject>();
    int tailleList;
    int indexPlayer = 0;
    public int vie;
    [SerializeField]int money;
    private void Start()
    {
        tailleList = movements.Count;
        Physics.IgnoreLayerCollision(6, 6, true);
    }

    private void FixedUpdate()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, movements[indexPlayer].transform.position, Time.deltaTime * vitesse);
        gameObject.transform.LookAt(movements[indexPlayer].transform.position);
        if (Vector3.Distance(this.gameObject.transform.position, movements[indexPlayer].transform.position) <= 0.1)
        {
            indexPlayer++;
        }
        if(vie <= 0)
        {
            Die();
        }
    }

    public void TakeDamage(int damage)
    {
        vie -= damage;
    }
    public void Die()
    {
        GameObject.Find("GameManager").GetComponent<Money>().Add(money);
        Destroy(this.gameObject);
    }
}
