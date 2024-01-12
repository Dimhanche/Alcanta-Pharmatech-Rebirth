using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    MenuManager tuto;
    [SerializeField]private GameObject iso, dessus;
    [SerializeField]private Canvas hud, Canvas;
    private void Awake()
    {
        tuto = GameObject.Find("MenuManager").GetComponent<MenuManager>();
        iso.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(1) && !tuto.menututo.activeSelf)
        {
            if(iso.activeSelf)
            {
                iso.SetActive(false);
                dessus.SetActive(true);
                hud.worldCamera = dessus.GetComponent<Camera>();
                Canvas.worldCamera = dessus.GetComponent<Camera>();
            }
            else
            {
                iso.SetActive(true);
                dessus.SetActive(false);
                hud.worldCamera = iso.GetComponent<Camera>();
                Canvas.worldCamera = iso.GetComponent<Camera>();
            }
        }
    }
}
