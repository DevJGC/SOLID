using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void Change(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
