using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomShopGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        void CreateFeed()
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
        void CreateFeed()
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
        void CreateFeed()
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
        void CreateFeed()
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
        void CreateFeed()
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
        void CreateFeed()
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
        void CreateFeed()
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
        void CreateFeed()
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
        void CreateFeed()
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
    }
}
