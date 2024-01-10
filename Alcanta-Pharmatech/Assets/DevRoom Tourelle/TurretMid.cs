using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class TurretMid : MonoBehaviour
{
    [SerializeField]private List<GameObject> inRange = new List<GameObject>();
    [SerializeField]int cooldown = 1;
    [SerializeField]int damage = 5;
    [SerializeField]int range = 3;
    private List<GameObject> toKill = new List<GameObject>();

    private void Start()
    {
        StartCoroutine(Shoot());
    }
    IEnumerator Shoot()
    {
            foreach(GameObject ennemi in GameObject.FindGameObjectsWithTag("ennemi"))
            {
                print(ennemi.gameObject.name);
                if(Vector3.Distance(ennemi.transform.position,gameObject.transform.position)<=range)
                {
                    ennemi.GetComponent<Movement>().vie -= damage;
                }
            }
        yield return new WaitForSeconds(cooldown);
        Kill();
        StartCoroutine(Shoot());
    }
    private void Kill()
    {
        for(int i = 0;i < toKill.Count;i++)
        {
            Destroy(toKill[i]);
        }
    }
}
