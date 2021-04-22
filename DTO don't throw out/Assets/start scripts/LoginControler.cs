using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginControler : MonoBehaviour
{
    public int scene;

    public InputField UserName;
    public InputField Password;
    public GameObject Error;
    public GameObject login;
    public GameObject register;
    public void Login()
    {
        string username = UserName.text + "Pword";
        print(username);
        string aPassword = PlayerPrefs.GetString(username);
        if (aPassword == Password.text)
        {
            PlayerPrefs.SetString("ActiveUser", UserName.text);
            print("Active User" + UserName.text);
            SceneManager.LoadScene(scene);
        }
        else
        {
            Error.SetActive(true);
        }
    }
    public void Register()
    {
        login.SetActive(false);
        register.SetActive(true);
    }
}
