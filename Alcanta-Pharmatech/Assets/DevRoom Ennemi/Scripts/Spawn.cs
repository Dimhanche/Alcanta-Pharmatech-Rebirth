using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]private int nbEnnemi;
    int nbEnnmiTotal = 0;
    [SerializeField]private float timerEnnemi;
    [SerializeField]private float spawnTime;
    [SerializeField]private int round = 0;
    [SerializeField]private GameObject fastEnnemy,middleEnnemi;
    [SerializeField]private Transform ennemiParent;
    [SerializeField]private List<GameObject> waypoints;

    private void Start()
    {
        StartCoroutine(SpawnEnnemi());
    }
    IEnumerator SpawnEnnemi()
    {
        nbEnnemi = Random.Range(1+round, nbEnnemi+round);
        for(int i = 0; i < nbEnnemi; i++)
        {
            switch(Random.Range(0, 2))
            {
                case 0:
                    GameObject fastEnnemi = Instantiate(fastEnnemy, waypoints[0].transform.position, Quaternion.identity, ennemiParent) as GameObject;
                    fastEnnemi.name = nbEnnmiTotal.ToString()+"fast";
                    fastEnnemi.GetComponent<Movement>().movements = waypoints;
                    break; 
                case 1:
                    GameObject midEnnemi = Instantiate(middleEnnemi, waypoints[0].transform.position, Quaternion.Euler(0f, 180f, 0f), ennemiParent) as GameObject;
                    midEnnemi.name = nbEnnmiTotal.ToString() + "mid";
                    midEnnemi.GetComponentInChildren<Movement>().movements = waypoints;
                    break;
                default:
                    Debug.Log("Error");
                    break;
            }
            nbEnnmiTotal++;
            yield return new WaitForSeconds(timerEnnemi);
        }
        yield return new WaitForSeconds(spawnTime);
        round ++;
        StartCoroutine(SpawnEnnemi());
    }
}
