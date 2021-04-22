using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterControler : MonoBehaviour
{
    public int check = 0;
    //input
    public InputField Fname;
    public InputField Lname;
    public InputField Email;
    public InputField Day;
    public InputField Month;
    public InputField Year;
    public InputField Uname;
    public InputField Pword;
    public InputField RePword;
    //error
    public GameObject userExists;
    public GameObject pwordsDontMatch;
    //canvas
    public GameObject login;
    public GameObject register;
    // Update is called once per frame
    public void Check()
    {
        string cUname = Uname.text + "ID";
        int checkIfExsists = PlayerPrefs.GetInt(cUname);
        if (checkIfExsists == 1)
        {
            check = check + 1;
            userExists.SetActive(true);
        }
        else
        {
            if (Pword.text == RePword.text)
            {
                check = check + 1;
                string unm = Uname.text;
                //sets user as active
                string SetUserID = unm + "ID";
                PlayerPrefs.SetInt(SetUserID, 1);
                //sets users Firstname
                string fname = unm + "Fname";
                PlayerPrefs.SetString(fname, Fname.text);
                //sets users Lastname
                string lname = unm + "Lname";
                PlayerPrefs.SetString(lname, Lname.text);
                //sets users Email
                string email = unm + "Email";
                PlayerPrefs.SetString(email, Email.text);
                //sets users birthday
                string birthday = unm + "Birthday";
                string ubirth = Day.text + " - " + Month + " - " + Year.text;
                PlayerPrefs.SetString(birthday, ubirth);
                //sets users Password
                string pword = unm + "Pword";
                PlayerPrefs.SetString(pword, Pword.text);
                print("New User: " + Uname.text);
            }
            else
            {
                pwordsDontMatch.SetActive(true);
            }
        }
    }
    public void opret()
    {
        if (check == 2)
        {
            login.SetActive(true);
            register.SetActive(false);
        }
    }
    public void Login()
    {
        login.SetActive(true);
        register.SetActive(false);
    }
}
