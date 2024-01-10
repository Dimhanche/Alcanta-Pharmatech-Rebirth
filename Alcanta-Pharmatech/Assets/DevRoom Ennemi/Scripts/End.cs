using UnityEngine;

public class End : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print(collision);
        if(collision.gameObject.tag == "ennemi")
        {
            Destroy(collision.gameObject);
        }
    }
}
