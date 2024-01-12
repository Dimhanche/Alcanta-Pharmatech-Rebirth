using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [Header ("gameobjects")]
    [SerializeField] private int vie = 3;
    public GameObject menuCredits;
    public GameObject menuOptions;
    public GameObject menuQuit;
    public GameObject menuInGame;
    public Slider vieSlider;
    void Start()
    {
        menuCredits.SetActive(false);
        menuOptions.SetActive(false);
        menuQuit.SetActive(false);
        menuInGame.SetActive(false);
        if(vieSlider != null)
        {
            vieSlider.value = vie;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse2) && !menuInGame.activeSelf)
        {
            OpenmenuInGame();
            OpenMenuOptions();
        }
        else if (Input.GetKeyDown(KeyCode.Mouse2) && menuInGame.activeSelf)
        {
            ClosemenuInGame();
            CloseMenuOptions();
        }
    }
    public void LooseLife()
    {
        if (vie > 0)
        {
            vie--;
            vieSlider.value = vie;
        }
        if (vie <= 0)
        {
            Loose();
        }
    }
    public void AddLife()
    {
        if(vie <3)
        {
            vie++;
            vieSlider.value = vie;
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
        CloseMenu();
    }
    public void OpenMenuOptions()
    {
        CloseMenu();
        menuOptions.SetActive(true);
    }
    public void CloseMenuOptions()
    {
        menuOptions.SetActive(false);
        ClosemenuInGame();
        CloseMenu();
        Resume();
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