using UnityEngine;

public class End : MonoBehaviour
{
    GameManager manager;
    private void Awake()
    {

        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ennemi")
        {
            manager.LooseLife();
            Destroy(collision.gameObject);
        }
    }
}
