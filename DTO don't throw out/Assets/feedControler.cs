using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class feedControler : MonoBehaviour
{
    //shoplist
    public GameObject Shoplist;
    //shopBoxes
    public GameObject Føtex;
    public GameObject Kvickly;
    public GameObject Netto;
    public GameObject Aldi;
    public GameObject Rema;
    public GameObject Irma;
    public GameObject Lidl;
    public GameObject Fakta;
    //searchbar
    public InputField SearchBar;
    //city
    public Text City;
    private string ToValue;
    //value
    private int Value;
    // Start is called before the first frame update
    void Awake()
    {
        int shops = Random.Range(1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (SearchBar.text.Length < 1)
            {
                string User = PlayerPrefs.GetString("ActiveUser");
                string UserCity = User + "City";
                ToValue = PlayerPrefs.GetString(UserCity);
                City.text = ToValue;
                PlayerPrefs.SetString("City", ToValue);
            }
            else
            {
                City.text = SearchBar.text;
                ToValue = SearchBar.text;
                PlayerPrefs.SetString("City", ToValue);
                GetValue();
            }
        }
    }
    void GetValue()
    {
        CreateFeed();
        if (ToValue.Length < 10)
        {
            Value = ToValue.Length;
        }
        else if (ToValue.Length < 20)
        {
            Value = Mathf.RoundToInt(ToValue.Length / 2);
            print(Value);
        }
        else if (ToValue.Length < 30)
        {
            Value = Mathf.RoundToInt(ToValue.Length / 3);
            print(Value);
        }
        else
        {
            Value = Random.Range(1, 10);
            print(Value);
        }
    }
}
