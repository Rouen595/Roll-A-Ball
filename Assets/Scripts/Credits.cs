using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void PlayAgain()
    {
        Debug.Log("Loading menu...");
        Time.timeScale = 1f;
        ChangeSpeed.gameSpeed = 1f;
        PickColor.playerColor = 1;
        GiantMode.giant = false;
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
