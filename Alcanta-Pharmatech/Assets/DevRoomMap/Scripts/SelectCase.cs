using UnityEngine;

public class SelectCase : MonoBehaviour
{
    [SerializeField]private GameObject select,marketHud;
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 50) && Input.GetMouseButtonDown(0))
        {
            if(hit.collider.tag == "ground")
            {
                select.SetActive(true);
                select.transform.position = hit.collider.gameObject.transform.position;
                marketHud.SetActive(true);
                marketHud.GetComponent<AddTurret>().positionSelect = select;
            }
            else if (hit.collider.tag == "void")
            {
                select.SetActive(false);
                marketHud.SetActive(false);
            }
        }
    }
}
