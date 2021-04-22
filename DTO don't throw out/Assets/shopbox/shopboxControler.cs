using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopboxControler : MonoBehaviour
{
    //items left
    private int ItemLeft;
    //text
    public Text ItemText;
    // Start is called before the first frame update
    void Awake()
    {
        int range = Random.Range(1, 8);
        if (range == 6)
        {
            ItemLeft = Random.Range(20, 30);
        }
        else if (range <= 3)
        {
            ItemLeft = Random.Range(10, 20);
        }
        else if (range <= 5)
        {
            ItemLeft = Random.Range(1, 10);
        }
        else
        {
            ItemLeft = 0;
        }
        ItemText.text = "" + ItemLeft;
    }
    public void LoadShop()
    {
        PlayerPrefs.SetInt("Items", ItemLeft);
    }
}
