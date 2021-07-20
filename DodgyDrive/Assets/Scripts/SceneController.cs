using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour 
{
    //public bool canPause = false;

    //private void Update()
    //{
    //    if (canPause == true && Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        Time.timeScale = 0;
    //        MenuOpen();
    //    }
    //}
    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
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
