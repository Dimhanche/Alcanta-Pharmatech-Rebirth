using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [Header ("gameobjects")]
    [SerializeField] private int vie = 3;
    public GameObject menuCredits;
    public GameObject menuOptions;
    public GameObject menuQuit;
    public GameObject menuInGame;
    void Start()
    {
        menuCredits.SetActive(false);
        menuOptions.SetActive(false);
        menuQuit.SetActive(false);
        menuInGame.SetActive(false);
    }
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
    public void LooseLife()
    {
        if (vie > 0)
        {
            vie--;
        }
        if (vie <= 0)
        {
            Loose();
        }
    }
    private void Loose()
    {
        menuInGame.SetActive(true);
    }
    public void Jouer()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MainMenu");
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

    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void Resume()
    {
        Time.timeScale = 1;
    }
    public void GoFast()
    {
        Time.timeScale = 2;
    }
}