using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public void GameEnd()
    {
        Application.Quit();
    }
}