using UnityEngine;

public class End : MonoBehaviour
{
    MenuManager manager;
    private void Awake()
    {
        manager = GameObject.Find("MenuManager").GetComponent<MenuManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ennemi")
        {
            manager.LooseLife();
            collision.gameObject.GetComponent<Movement>().TakeDamage(50);
        }
    }
}
