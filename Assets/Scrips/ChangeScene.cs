using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public void ChangeScene(string MainScene)
    {
        SceneManager.LoadScene(MainScene);
    }
}