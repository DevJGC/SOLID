using UnityEngine;

public class ExitGame : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
          if (Input.GetKey("escape"))
          {
            Exit();
          }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
