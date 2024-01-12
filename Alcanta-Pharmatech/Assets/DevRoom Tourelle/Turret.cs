using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class TurretMid : MonoBehaviour
{
    [SerializeField]float cooldown = 1;
    [SerializeField]int damage = 5;
    [SerializeField]float range = 3;
    bool shoot = false;
    public Animator anim;

    private void Start()
    {
        StartCoroutine(Shoot());
    }
    IEnumerator Shoot()
    {
        shoot = false;
        foreach(GameObject ennemi in GameObject.FindGameObjectsWithTag("ennemi"))
        {
            if(Vector3.Distance(ennemi.transform.position,this.gameObject.transform.position)<=range &&!shoot)
            {
                shoot = true;
                if (ennemi != null)
                {
                    anim = ennemi.GetComponent<Animator>();
                    anim.SetBool("Damage",true);
                    gameObject.GetComponentInChildren<Transform>().LookAt(ennemi.transform.position);
                    anim.SetBool("Damage", false);
                    ennemi.GetComponent<Movement>().vie -= damage;
                }
            }
        }
        yield return new WaitForSeconds(cooldown);
        StartCoroutine(Shoot());
    }
}
