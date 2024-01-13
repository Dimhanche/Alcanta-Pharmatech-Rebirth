using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]private float vitesse;
    [SerializeField]public List<GameObject> movements = new List<GameObject>();
    int indexPlayer = 0;
    public int vie;
    [SerializeField]int money;
    public bool isAttacked = false;
    private void Start()
    {
        isAttacked = false;
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
        if(indexPlayer >= movements.Count)
        {
            MenuManager manager = GameObject.Find("MenuManager").GetComponent<MenuManager>();
            manager.LooseLife();
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        vie -= damage;
        gameObject.GetComponentInChildren<ParticleSystem>().Play();
        if (vie <= 0)
        {
            GameObject.Find("GameManager").GetComponent<Money>().Add(money);
            Destroy(this.gameObject);
            return;
        }
        isAttacked = false;

    }
}
