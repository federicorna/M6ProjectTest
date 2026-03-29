
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui_MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;

    public void OnClickNewGame()
    {
        SceneManager.LoadScene ("Level");
    }


    public void OnClickExit()
    {
        Debug.Log ("Exit");
        Application.Quit();
    }
}
