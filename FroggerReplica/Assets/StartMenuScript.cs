using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour
{
    public void ChangeMenuScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
