using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject menuCredits;
    public GameObject menuOptions;
    public GameObject menuQuit;
    public GameObject menuInGame;
    // Start is called before the first frame update
    void Start()
    {
        menuCredits.SetActive(false);
        menuOptions.SetActive(false);
        menuQuit.SetActive(false);
        menuInGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !menuInGame.activeSelf)
        {
            OpenmenuInGame();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && menuInGame.activeSelf)
        {
            ClosemenuInGame();
        }
    }

    public void Jouer()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
    public void OpenMenuCredits()
    {
        CloseMenu();
        menuCredits.SetActive(true);
    }
    public void CloseMenuCredits()
    {
        menuCredits.SetActive(false);
    }
    public void OpenmenuInGame()
    {
        menuInGame.SetActive(true);
        Time.timeScale = 0;
    }
    public void ClosemenuInGame()
    {
        Time.timeScale = 1;
        menuInGame.SetActive(false);

    }
    public void OpenMenuOptions()
    {
        CloseMenu();
        menuOptions.SetActive(true);
    }
    public void CloseMenuOptions()
    {
        menuOptions.SetActive(false);
    }
    public void OpenQuitMenu()
    {
        CloseMenu();
        menuQuit.SetActive(true);
    }
    public void CloseQuitMenu()
    {
        menuQuit.SetActive(false);
    }
    public void OpenMenuOptionsW()
    {
        CloseMenu();
        menuOptions.SetActive(true);
    }
    public void CloseMenu()
    {
        menuCredits.SetActive(false);
        menuOptions.SetActive(false);
        menuQuit.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
}