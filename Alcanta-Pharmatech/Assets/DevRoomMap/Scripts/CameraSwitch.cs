using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField]private GameObject iso, dessus;
    [SerializeField]private Canvas hud;
    private void Awake()
    {
        iso.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(iso.activeSelf)
            {
                iso.SetActive(false);
                dessus.SetActive(true);
                hud.worldCamera = dessus.GetComponent<Camera>();
            }
            else
            {
                iso.SetActive(true);
                dessus.SetActive(false);
                hud.worldCamera = iso.GetComponent<Camera>();
            }
        }
    }
}
