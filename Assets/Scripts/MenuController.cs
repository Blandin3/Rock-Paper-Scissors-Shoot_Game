using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject homePage;
    public GameObject howToPlayPage;
    public GameObject settingsPage;
    public GameObject aboutPage;

    public void ShowHome()
    {
        homePage.SetActive(true);
        howToPlayPage.SetActive(false);
        settingsPage.SetActive(false);
        aboutPage.SetActive(false);
    }

    public void ShowHowToPlay()
    {
        homePage.SetActive(false);
        howToPlayPage.SetActive(true);
        settingsPage.SetActive(false);
        aboutPage.SetActive(false);
    }

    public void ShowSettings()
    {
        homePage.SetActive(false);
        howToPlayPage.SetActive(false);
        settingsPage.SetActive(true);
        aboutPage.SetActive(false);
    }

    public void ShowAbout()
    {
        homePage.SetActive(false);
        howToPlayPage.SetActive(false);
        settingsPage.SetActive(false);
        aboutPage.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

