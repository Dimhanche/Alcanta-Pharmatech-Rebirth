using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class TurretMid : MonoBehaviour
{
    [SerializeField]float cooldown = 1;
    [SerializeField]int damage = 5;
    [SerializeField]float range = 3;
     public bool shoot = false;
    public GameObject testEnnemy;
    [SerializeField] float roty;

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
                    testEnnemy = ennemi;
                    gameObject.GetComponent<Transform>().LookAt(ennemi.transform.position);
                    roty = gameObject.GetComponent<Transform>().rotation.y;
                    gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(0, roty*10, 0);
                    ennemi.GetComponent<Movement>().TakeDamage(damage);
                }
            }
        }
        yield return new WaitForSeconds(cooldown);
        StartCoroutine(Shoot());
    }
}
