using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class TurretMid : MonoBehaviour
{
    [SerializeField]float cooldown = 1;
    [SerializeField]int damage = 5;
    [SerializeField]float range = 3;
     public bool shoot = false;
    [SerializeField] bool canRot;

    private void Start()
    {
        StartCoroutine(Shoot());
    }
    IEnumerator Shoot()
    {
        shoot = false;
        foreach(GameObject ennemi in GameObject.FindGameObjectsWithTag("ennemi"))
        {
            if (Vector3.Distance(ennemi.transform.position, this.gameObject.transform.position) <= range && !shoot)
            {
                shoot = true;
                if (ennemi != null)
                {
                    if (canRot)
                    {
                        gameObject.GetComponent<Transform>().LookAt(ennemi.transform.position);
                    }
                    ennemi.GetComponent<Movement>().TakeDamage(damage);
                }
            }
        }
        yield return new WaitForSeconds(cooldown);
        StartCoroutine(Shoot());
    }
}
