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
            }
            else
            {
                City.text = SearchBar.text;
                ToValue = SearchBar.text;
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
    void CreateFeed()
    {
        //shop_1 yPos 500
        GameObject shop_1 = Instantiate(Føtex);
        shop_1.transform.parent = Shoplist.transform;
        shop_1.transform.localScale = new Vector3(1, 1, 1);
        shop_1.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 500, 0);
        //shop_2 yPos 150
        GameObject shop_2 = Instantiate(Kvickly);
        shop_2.transform.parent = Shoplist.transform;
        shop_2.transform.localScale = new Vector3(1, 1, 1);
        shop_2.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 150, 0);
        //shop_3 yPos -200
        GameObject shop_3 = Instantiate(Rema);
        shop_3.transform.parent = Shoplist.transform;
        shop_3.transform.localScale = new Vector3(1, 1, 1);
        shop_3.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -200, 0);
        //shop_1 yPos -550
        GameObject shop_4 = Instantiate(Fakta);
        shop_4.transform.parent = Shoplist.transform;
        shop_4.transform.localScale = new Vector3(1, 1, 1);
        shop_4.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -550, 0);
    }
}
