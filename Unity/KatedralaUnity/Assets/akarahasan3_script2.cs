using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class akarahasan3_script2 : MonoBehaviour
{
    // Use this for initialization
    public GameObject helpTekst;
    public string Url = "https://c2.etf.unsa.ba/course/view.php?id=44";
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void funkcijaOnClick()
    {
        Application.Quit();
    }

    public void funkcijaInfo()
    {
        Application.OpenURL(Url);
        
    }

    public void funkcijaHelp()
    {
        if (helpTekst.activeInHierarchy == true)
        {
            helpTekst.SetActive(false);
        }
        else
        {
            helpTekst.SetActive(true);
        }
    }

}
