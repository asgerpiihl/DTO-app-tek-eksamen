using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopSiteControler : MonoBehaviour
{
    //shop logos
    public Sprite Føtex;
    public Sprite Kvickly;
    public Sprite Netto;
    public Sprite Aldi;
    public Sprite Rema;
    public Sprite Irma;
    public Sprite Lidl;
    public Sprite Fakta;
    //Info
    public Text City;
    public Image Logo;
    private int ItemLeft;
    // Start is called before the first frame update
    void Start()
    {
        City.text = PlayerPrefs.GetString("City");
        string Shop = PlayerPrefs.GetString("Shop");
        if (Shop == "Føtex")
        {
            Logo.sprite = Føtex;
        }
        else if (Shop == "Kvickly")
        {
            Logo.sprite = Kvickly;
        }
        else if (Shop == "Netto")
        {
            Logo.sprite = Netto;
        }
        else if (Shop == "Aldi")
        {
            Logo.sprite = Aldi;
        }
        else if (Shop == "Rema")
        {
            Logo.sprite = Rema;
        }
        print(Shop);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
