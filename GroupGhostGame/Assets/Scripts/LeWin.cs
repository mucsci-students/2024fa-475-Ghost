using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeWin : MonoBehaviour
{
    public void GoMain()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void Quit()
    {
       Application.Quit();
    }
}
