using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseManager : MonoBehaviour
{
    public void Back()
    {
        SessionData.UserName = null;
        SceneManager.LoadScene("Login");

    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Home()
    {
        SceneManager.LoadScene("ApplicationScene");
    }
    public void Office()
    {
        SceneManager.LoadScene("ApplicationScene");
    }

}
