using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadecanvas : MonoBehaviour
{
    public GameObject SplashScreen;
    public GameObject Login;
    public Image Logo;
    private float Trans;
    // Start is called before the first frame update
    void Start()
    {
        Trans = 1f;
        InvokeRepeating("Fade", 1f, 0.08f);
    }

    // Update is called once per frame
    void Fade()
    {
        Trans = Trans - 0.025f;
        FadeImg();
    }
    void FadeImg()
    {
        if (Trans <= -0.25f)
        {
            CancelInvoke("Fade");
            SplashScreen.SetActive(false);
            Login.SetActive(true);
        }
        else
        {
            Logo.color = new Color(1, 1, 1, Trans);
        }
    }
}
