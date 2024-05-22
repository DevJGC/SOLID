using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    void Start()
    {
        
    }

    public void Change(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
