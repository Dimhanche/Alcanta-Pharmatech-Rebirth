using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField]float cooldown = 1;
    [SerializeField]int damage = 5;
    [SerializeField]float range = 3;
     public bool shoot = false;
    [SerializeField] bool canRot;
    AudioShoot isPlayedAlready;
    [SerializeField] GameObject target;
    private void Start()
    {
        isPlayedAlready = GetComponent<AudioShoot>();
        StartCoroutine(Shoot());
    }
    IEnumerator Shoot()
    {
        isPlayedAlready.AlreadyPlayed = false;
        shoot = false;
        foreach(GameObject ennemi in GameObject.FindGameObjectsWithTag("ennemi"))
        {
            target = ennemi;
            if (target != null)
            {
                if (target.GetComponent<Movement>().isAttacked == false)
                {
                    if (Vector3.Distance(target.transform.position, gameObject.transform.position) <= range && !shoot)
                    {
                        target.GetComponent<Movement>().isAttacked = true;
                        shoot = true;
                        if (canRot)
                        {
                            gameObject.GetComponentInChildren<Transform>().LookAt(target.transform.position);
                        }
                        target.GetComponent<Movement>().TakeDamage(damage);
                    }
                }
            }
            
        }
        yield return new WaitForSeconds(cooldown);
        StartCoroutine(Shoot());
    }
}
