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
        string User = PlayerPrefs.GetString("ActiveUser");
        string UserCity = User + "City";
        ToValue = "Frederikssund";//PlayerPrefs.GetString(UserCity);
        City.text = ToValue;
        PlayerPrefs.SetString("City", ToValue);
        GetValue();
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
                GetValue();
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
        if (ToValue.Length < 10)
        {
            Value = ToValue.Length;
            CreateFeed();
        }
        else if (ToValue.Length < 20)
        {
            Value = Mathf.RoundToInt(ToValue.Length / 2);
            print(Value);
            CreateFeed();
        }
        else if (ToValue.Length < 30)
        {
            Value = Mathf.RoundToInt(ToValue.Length / 3);
            print(Value);
            CreateFeed();
        }
        else
        {
            Value = Random.Range(1, 10);
            print(Value);
            CreateFeed();
        }
    }
    void CreateFeed()
    {
        if (Value == 1)
        {
            //shop_1 yPos 500
            GameObject shop_1 = Instantiate(Fakta);
            shop_1.transform.parent = Shoplist.transform;
            shop_1.transform.localScale = new Vector3(1, 1, 1);
            shop_1.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 500, 0);
            //shop_2 yPos 150
            GameObject shop_2 = Instantiate(Føtex);
            shop_2.transform.parent = Shoplist.transform;
            shop_2.transform.localScale = new Vector3(1, 1, 1);
            shop_2.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 150, 0);
            //shop_3 yPos -200
            GameObject shop_3 = Instantiate(Lidl);
            shop_3.transform.parent = Shoplist.transform;
            shop_3.transform.localScale = new Vector3(1, 1, 1);
            shop_3.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -200, 0);
            //shop_1 yPos -550
            GameObject shop_4 = Instantiate(Netto);
            shop_4.transform.parent = Shoplist.transform;
            shop_4.transform.localScale = new Vector3(1, 1, 1);
            shop_4.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -550, 0);
        }
        else if (Value == 2)
        {
            //shop_1 yPos 500
            GameObject shop_1 = Instantiate(Aldi);
            shop_1.transform.parent = Shoplist.transform;
            shop_1.transform.localScale = new Vector3(1, 1, 1);
            shop_1.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 500, 0);
            //shop_2 yPos 150
            GameObject shop_2 = Instantiate(Føtex);
            shop_2.transform.parent = Shoplist.transform;
            shop_2.transform.localScale = new Vector3(1, 1, 1);
            shop_2.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 150, 0);
            //shop_3 yPos -200
            GameObject shop_3 = Instantiate(Lidl);
            shop_3.transform.parent = Shoplist.transform;
            shop_3.transform.localScale = new Vector3(1, 1, 1);
            shop_3.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -200, 0);
            //shop_1 yPos -550
            GameObject shop_4 = Instantiate(Rema);
            shop_4.transform.parent = Shoplist.transform;
            shop_4.transform.localScale = new Vector3(1, 1, 1);
            shop_4.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -550, 0);
        }
        else if (Value == 3)
        {
            //shop_1 yPos 500
            GameObject shop_1 = Instantiate(Aldi);
            shop_1.transform.parent = Shoplist.transform;
            shop_1.transform.localScale = new Vector3(1, 1, 1);
            shop_1.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 500, 0);
            //shop_2 yPos 150
            GameObject shop_2 = Instantiate(Fakta);
            shop_2.transform.parent = Shoplist.transform;
            shop_2.transform.localScale = new Vector3(1, 1, 1);
            shop_2.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 150, 0);
            //shop_3 yPos -200
            GameObject shop_3 = Instantiate(Netto);
            shop_3.transform.parent = Shoplist.transform;
            shop_3.transform.localScale = new Vector3(1, 1, 1);
            shop_3.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -200, 0);
            //shop_1 yPos -550
            GameObject shop_4 = Instantiate(Rema);
            shop_4.transform.parent = Shoplist.transform;
            shop_4.transform.localScale = new Vector3(1, 1, 1);
            shop_4.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -550, 0);
        }
        else if (Value == 4)
        {
            //shop_1 yPos 500
            GameObject shop_1 = Instantiate(Irma);
            shop_1.transform.parent = Shoplist.transform;
            shop_1.transform.localScale = new Vector3(1, 1, 1);
            shop_1.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 500, 0);
            //shop_2 yPos 150
            GameObject shop_2 = Instantiate(Fakta);
            shop_2.transform.parent = Shoplist.transform;
            shop_2.transform.localScale = new Vector3(1, 1, 1);
            shop_2.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 150, 0);
            //shop_3 yPos -200
            GameObject shop_3 = Instantiate(Føtex);
            shop_3.transform.parent = Shoplist.transform;
            shop_3.transform.localScale = new Vector3(1, 1, 1);
            shop_3.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -200, 0);
            //shop_1 yPos -550
            GameObject shop_4 = Instantiate(Kvickly);
            shop_4.transform.parent = Shoplist.transform;
            shop_4.transform.localScale = new Vector3(1, 1, 1);
            shop_4.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -550, 0);
        }
        else if (Value == 5)
        {
            //shop_1 yPos 500
            GameObject shop_1 = Instantiate(Aldi);
            shop_1.transform.parent = Shoplist.transform;
            shop_1.transform.localScale = new Vector3(1, 1, 1);
            shop_1.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 500, 0);
            //shop_2 yPos 150
            GameObject shop_2 = Instantiate(Irma);
            shop_2.transform.parent = Shoplist.transform;
            shop_2.transform.localScale = new Vector3(1, 1, 1);
            shop_2.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 150, 0);
            //shop_3 yPos -200
            GameObject shop_3 = Instantiate(Føtex);
            shop_3.transform.parent = Shoplist.transform;
            shop_3.transform.localScale = new Vector3(1, 1, 1);
            shop_3.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -200, 0);
            //shop_1 yPos -550
            GameObject shop_4 = Instantiate(Kvickly);
            shop_4.transform.parent = Shoplist.transform;
            shop_4.transform.localScale = new Vector3(1, 1, 1);
            shop_4.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -550, 0);
        }
        else if (Value == 6)
        {
            //shop_1 yPos 500
            GameObject shop_1 = Instantiate(Irma);
            shop_1.transform.parent = Shoplist.transform;
            shop_1.transform.localScale = new Vector3(1, 1, 1);
            shop_1.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 500, 0);
            //shop_2 yPos 150
            GameObject shop_2 = Instantiate(Føtex);
            shop_2.transform.parent = Shoplist.transform;
            shop_2.transform.localScale = new Vector3(1, 1, 1);
            shop_2.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 150, 0);
            //shop_3 yPos -200
            GameObject shop_3 = Instantiate(Lidl);
            shop_3.transform.parent = Shoplist.transform;
            shop_3.transform.localScale = new Vector3(1, 1, 1);
            shop_3.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -200, 0);
            //shop_1 yPos -550
            GameObject shop_4 = Instantiate(Rema);
            shop_4.transform.parent = Shoplist.transform;
            shop_4.transform.localScale = new Vector3(1, 1, 1);
            shop_4.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -550, 0);
        }
        else if (Value == 7)
        {
            //shop_1 yPos 500
            GameObject shop_1 = Instantiate(Irma);
            shop_1.transform.parent = Shoplist.transform;
            shop_1.transform.localScale = new Vector3(1, 1, 1);
            shop_1.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 500, 0);
            //shop_2 yPos 150
            GameObject shop_2 = Instantiate(Kvickly);
            shop_2.transform.parent = Shoplist.transform;
            shop_2.transform.localScale = new Vector3(1, 1, 1);
            shop_2.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 150, 0);
            //shop_3 yPos -200
            GameObject shop_3 = Instantiate(Netto);
            shop_3.transform.parent = Shoplist.transform;
            shop_3.transform.localScale = new Vector3(1, 1, 1);
            shop_3.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -200, 0);
            //shop_1 yPos -550
            GameObject shop_4 = Instantiate(Rema);
            shop_4.transform.parent = Shoplist.transform;
            shop_4.transform.localScale = new Vector3(1, 1, 1);
            shop_4.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -550, 0);
        }
        else if (Value == 8)
        {
            //shop_1 yPos 500
            GameObject shop_1 = Instantiate(Aldi);
            shop_1.transform.parent = Shoplist.transform;
            shop_1.transform.localScale = new Vector3(1, 1, 1);
            shop_1.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 500, 0);
            //shop_2 yPos 150
            GameObject shop_2 = Instantiate(Irma);
            shop_2.transform.parent = Shoplist.transform;
            shop_2.transform.localScale = new Vector3(1, 1, 1);
            shop_2.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 150, 0);
            //shop_3 yPos -200
            GameObject shop_3 = Instantiate(Fakta);
            shop_3.transform.parent = Shoplist.transform;
            shop_3.transform.localScale = new Vector3(1, 1, 1);
            shop_3.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -200, 0);
            //shop_1 yPos -550
            GameObject shop_4 = Instantiate(Lidl);
            shop_4.transform.parent = Shoplist.transform;
            shop_4.transform.localScale = new Vector3(1, 1, 1);
            shop_4.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -550, 0);
        }
        else if (Value == 9)
        {
            //shop_1 yPos 500
            GameObject shop_1 = Instantiate(Fakta);
            shop_1.transform.parent = Shoplist.transform;
            shop_1.transform.localScale = new Vector3(1, 1, 1);
            shop_1.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 500, 0);
            //shop_2 yPos 150
            GameObject shop_2 = Instantiate(Lidl);
            shop_2.transform.parent = Shoplist.transform;
            shop_2.transform.localScale = new Vector3(1, 1, 1);
            shop_2.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 150, 0);
            //shop_3 yPos -200
            GameObject shop_3 = Instantiate(Netto);
            shop_3.transform.parent = Shoplist.transform;
            shop_3.transform.localScale = new Vector3(1, 1, 1);
            shop_3.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -200, 0);
            //shop_1 yPos -550
            GameObject shop_4 = Instantiate(Rema);
            shop_4.transform.parent = Shoplist.transform;
            shop_4.transform.localScale = new Vector3(1, 1, 1);
            shop_4.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -550, 0);
        }
        else
        {
            Value = Random.Range(1, 10);
            print("whyyyyy");
            CreateFeed();
        }
    }
}
