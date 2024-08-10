using UnityEngine.SceneManagement;
using UnityEngine;

public class Scenecontroller : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex=SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1); //Loads the next scene
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
}
