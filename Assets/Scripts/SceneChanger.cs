using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public void ChangeScene_Lvl1()
    {
        SceneManager.LoadScene("New Scene");
    }

    public void ExitGame()
     { 
        Application.Quit();
     }
}
