using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour 
{
    public GameObject menu;
    //public bool canPause = false;

    //private void Update()
    //{
    //    if (canPause == true && Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        Time.timeScale = 0;
    //        MenuOpen();
    //    }
    //}
    public void Play()
    {
        SceneManager.LoadScene("Level");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void MenuClose()
    {
        menu.SetActive(false);
    }
    public void MenuOpen()
    {
        menu.SetActive(true);
    }
    //public void Resume()
    //{
    //    Time.timeScale = 1;
    //    MenuClose();
    //}
    public void QuitGame()
    {
        Application.Quit();
    }
}
