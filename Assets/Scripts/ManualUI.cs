using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManualUI : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject tuto1, tuto2, tuto3, tuto4, tuto5, tuto6, tuto7, tuto8, tuto9, tuto10, tuto11, tuto12, tuto13, tuto14, tuto15,MUI,b1,b2,b3,b4,b5,b6,b7,b8,b9,b10,b11,b12,b13,b14,b15;
    private bool toggleM;

    public void ToggleManual()
    {
        toggleM = !toggleM;
        MUI.gameObject.SetActive(toggleM);
    }

    public void Seleccionar1()
    {
        tuto1.gameObject.SetActive(true);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(false);
        tuto5.gameObject.SetActive(false);
        tuto6.gameObject.SetActive(false);
        tuto7.gameObject.SetActive(false);
        tuto8.gameObject.SetActive(false);
        tuto9.gameObject.SetActive(false);
        tuto10.gameObject.SetActive(false);
        tuto11.gameObject.SetActive(false);
        tuto12.gameObject.SetActive(false);
        tuto13.gameObject.SetActive(false);
        tuto14.gameObject.SetActive(false);
        tuto15.gameObject.SetActive(false);
        b1.GetComponent<Image>().color = new Color32(50, 50, 50, 255);
        b2.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b3.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b4.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b5.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b6.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b7.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b8.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b9.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b10.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b11.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b12.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b13.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b14.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b15.GetComponent<Image>().color = new Color32(0, 0, 0, 255);

    }

    public void Seleccionar2()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(true);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(false);
        tuto5.gameObject.SetActive(false);
        tuto6.gameObject.SetActive(false);
        tuto7.gameObject.SetActive(false);
        tuto8.gameObject.SetActive(false);
        tuto9.gameObject.SetActive(false);
        tuto10.gameObject.SetActive(false);
        tuto11.gameObject.SetActive(false);
        tuto12.gameObject.SetActive(false);
        tuto13.gameObject.SetActive(false);
        tuto14.gameObject.SetActive(false);
        tuto15.gameObject.SetActive(false);
        b1.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b2.GetComponent<Image>().color = new Color32(50, 50, 50, 255);
        b3.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b4.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b5.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b6.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b7.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b8.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b9.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b10.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b11.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b12.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b13.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b14.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b15.GetComponent<Image>().color = new Color32(0, 0, 0, 255);

    }

    public void Seleccionar3()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(true);
        tuto4.gameObject.SetActive(false);
        tuto5.gameObject.SetActive(false);
        tuto6.gameObject.SetActive(false);
        tuto7.gameObject.SetActive(false);
        tuto8.gameObject.SetActive(false);
        tuto9.gameObject.SetActive(false);
        tuto10.gameObject.SetActive(false);
        tuto11.gameObject.SetActive(false);
        tuto12.gameObject.SetActive(false);
        tuto13.gameObject.SetActive(false);
        tuto14.gameObject.SetActive(false);
        tuto15.gameObject.SetActive(false);
        b1.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b2.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b3.GetComponent<Image>().color = new Color32(50, 50, 50, 255);
        b4.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b5.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b6.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b7.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b8.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b9.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b10.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b11.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b12.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b13.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b14.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b15.GetComponent<Image>().color = new Color32(0, 0, 0, 255);

    }

    public void Seleccionar4()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(true);
        tuto5.gameObject.SetActive(false);
        tuto6.gameObject.SetActive(false);
        tuto7.gameObject.SetActive(false);
        tuto8.gameObject.SetActive(false);
        tuto9.gameObject.SetActive(false);
        tuto10.gameObject.SetActive(false);
        tuto11.gameObject.SetActive(false);
        tuto12.gameObject.SetActive(false);
        tuto13.gameObject.SetActive(false);
        tuto14.gameObject.SetActive(false);
        tuto15.gameObject.SetActive(false);
        b1.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b2.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b3.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b4.GetComponent<Image>().color = new Color32(50, 50, 50, 255);
        b5.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b6.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b7.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b8.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b9.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b10.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b11.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b12.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b13.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b14.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b15.GetComponent<Image>().color = new Color32(0, 0, 0, 255);

    }

    public void Seleccionar5()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(false);
        tuto5.gameObject.SetActive(true);
        tuto6.gameObject.SetActive(false);
        tuto7.gameObject.SetActive(false);
        tuto8.gameObject.SetActive(false);
        tuto9.gameObject.SetActive(false);
        tuto10.gameObject.SetActive(false);
        tuto11.gameObject.SetActive(false);
        tuto12.gameObject.SetActive(false);
        tuto13.gameObject.SetActive(false);
        tuto14.gameObject.SetActive(false);
        tuto15.gameObject.SetActive(false);
        b1.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b2.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b3.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b4.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b5.GetComponent<Image>().color = new Color32(50, 50, 50, 255);
        b6.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b7.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b8.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b9.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b10.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b11.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b12.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b13.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b14.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b15.GetComponent<Image>().color = new Color32(0, 0, 0, 255);

    }

    public void Seleccionar6()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(false);
        tuto5.gameObject.SetActive(false);
        tuto6.gameObject.SetActive(true);
        tuto7.gameObject.SetActive(false);
        tuto8.gameObject.SetActive(false);
        tuto9.gameObject.SetActive(false);
        tuto10.gameObject.SetActive(false);
        tuto11.gameObject.SetActive(false);
        tuto12.gameObject.SetActive(false);
        tuto13.gameObject.SetActive(false);
        tuto14.gameObject.SetActive(false);
        tuto15.gameObject.SetActive(false);
        b1.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b2.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b3.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b4.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b5.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b6.GetComponent<Image>().color = new Color32(50, 50, 50, 255);
        b7.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b8.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b9.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b10.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b11.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b12.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b13.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b14.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b15.GetComponent<Image>().color = new Color32(0, 0, 0, 255);

    }

    public void Seleccionar7()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(false);
        tuto5.gameObject.SetActive(false);
        tuto6.gameObject.SetActive(false);
        tuto7.gameObject.SetActive(true);
        tuto8.gameObject.SetActive(false);
        tuto9.gameObject.SetActive(false);
        tuto10.gameObject.SetActive(false);
        tuto11.gameObject.SetActive(false);
        tuto12.gameObject.SetActive(false);
        tuto13.gameObject.SetActive(false);
        tuto14.gameObject.SetActive(false);
        tuto15.gameObject.SetActive(false);
        b1.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b2.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b3.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b4.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b5.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b6.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b7.GetComponent<Image>().color = new Color32(50, 50, 50, 255);
        b8.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b9.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b10.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b11.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b12.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b13.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b14.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b15.GetComponent<Image>().color = new Color32(0, 0, 0, 255);

    }

    public void Seleccionar8()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(false);
        tuto5.gameObject.SetActive(false);
        tuto6.gameObject.SetActive(false);
        tuto7.gameObject.SetActive(false);
        tuto8.gameObject.SetActive(true);
        tuto9.gameObject.SetActive(false);
        tuto10.gameObject.SetActive(false);
        tuto11.gameObject.SetActive(false);
        tuto12.gameObject.SetActive(false);
        tuto13.gameObject.SetActive(false);
        tuto14.gameObject.SetActive(false);
        tuto15.gameObject.SetActive(false);
        b1.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b2.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b3.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b4.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b5.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b6.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b7.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b8.GetComponent<Image>().color = new Color32(050, 50, 50, 255);
        b9.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b10.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b11.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b12.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b13.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b14.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b15.GetComponent<Image>().color = new Color32(0, 0, 0, 255);

    }

    public void Seleccionar9()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(false);
        tuto5.gameObject.SetActive(false);
        tuto6.gameObject.SetActive(false);
        tuto7.gameObject.SetActive(false);
        tuto8.gameObject.SetActive(false);
        tuto9.gameObject.SetActive(true);
        tuto10.gameObject.SetActive(false);
        tuto11.gameObject.SetActive(false);
        tuto12.gameObject.SetActive(false);
        tuto13.gameObject.SetActive(false);
        tuto14.gameObject.SetActive(false);
        tuto15.gameObject.SetActive(false);
        b1.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b2.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b3.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b4.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b5.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b6.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b7.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b8.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b9.GetComponent<Image>().color = new Color32(50, 50, 50, 255);
        b10.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b11.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b12.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b13.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b14.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b15.GetComponent<Image>().color = new Color32(0, 0, 0, 255);

    }

    public void Seleccionar10()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(false);
        tuto5.gameObject.SetActive(false);
        tuto6.gameObject.SetActive(false);
        tuto7.gameObject.SetActive(false);
        tuto8.gameObject.SetActive(false);
        tuto9.gameObject.SetActive(false);
        tuto10.gameObject.SetActive(true);
        tuto11.gameObject.SetActive(false);
        tuto12.gameObject.SetActive(false);
        tuto13.gameObject.SetActive(false);
        tuto14.gameObject.SetActive(false);
        tuto15.gameObject.SetActive(false);
        b1.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b2.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b3.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b4.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b5.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b6.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b7.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b8.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b9.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b10.GetComponent<Image>().color = new Color32(50, 50, 50, 255);
        b11.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b12.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b13.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b14.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b15.GetComponent<Image>().color = new Color32(0, 0, 0, 255);

    }

    public void Seleccionar11()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(false);
        tuto5.gameObject.SetActive(false);
        tuto6.gameObject.SetActive(false);
        tuto7.gameObject.SetActive(false);
        tuto8.gameObject.SetActive(false);
        tuto9.gameObject.SetActive(false);
        tuto10.gameObject.SetActive(false);
        tuto11.gameObject.SetActive(true);
        tuto12.gameObject.SetActive(false);
        tuto13.gameObject.SetActive(false);
        tuto14.gameObject.SetActive(false);
        tuto15.gameObject.SetActive(false);
        b1.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b2.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b3.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b4.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b5.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b6.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b7.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b8.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b9.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b10.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b11.GetComponent<Image>().color = new Color32(50, 50, 50, 255);
        b12.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b13.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b14.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b15.GetComponent<Image>().color = new Color32(0, 0, 0, 255);

    }

    public void Seleccionar12()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(false);
        tuto5.gameObject.SetActive(false);
        tuto6.gameObject.SetActive(false);
        tuto7.gameObject.SetActive(false);
        tuto8.gameObject.SetActive(false);
        tuto9.gameObject.SetActive(false);
        tuto10.gameObject.SetActive(false);
        tuto11.gameObject.SetActive(false);
        tuto12.gameObject.SetActive(true);
        tuto13.gameObject.SetActive(false);
        tuto14.gameObject.SetActive(false);
        tuto15.gameObject.SetActive(false);
        b1.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b2.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b3.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b4.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b5.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b6.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b7.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b8.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b9.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b10.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b11.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b12.GetComponent<Image>().color = new Color32(50, 50, 50, 255);
        b13.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b14.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b15.GetComponent<Image>().color = new Color32(0, 0, 0, 255);

    }

    public void Seleccionar13()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(false);
        tuto5.gameObject.SetActive(false);
        tuto6.gameObject.SetActive(false);
        tuto7.gameObject.SetActive(false);
        tuto8.gameObject.SetActive(false);
        tuto9.gameObject.SetActive(false);
        tuto10.gameObject.SetActive(false);
        tuto11.gameObject.SetActive(false);
        tuto12.gameObject.SetActive(false);
        tuto13.gameObject.SetActive(true);
        tuto14.gameObject.SetActive(false);
        tuto15.gameObject.SetActive(false);
        b1.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b2.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b3.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b4.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b5.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b6.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b7.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b8.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b9.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b10.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b11.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b12.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b13.GetComponent<Image>().color = new Color32(50, 50, 50, 255);
        b14.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b15.GetComponent<Image>().color = new Color32(0, 0, 0, 255);

    }

    public void Seleccionar14()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(false);
        tuto5.gameObject.SetActive(false);
        tuto6.gameObject.SetActive(false);
        tuto7.gameObject.SetActive(false);
        tuto8.gameObject.SetActive(false);
        tuto9.gameObject.SetActive(false);
        tuto10.gameObject.SetActive(false);
        tuto11.gameObject.SetActive(false);
        tuto12.gameObject.SetActive(false);
        tuto13.gameObject.SetActive(false);
        tuto14.gameObject.SetActive(true);
        tuto15.gameObject.SetActive(false);
        b1.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b2.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b3.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b4.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b5.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b6.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b7.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b8.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b9.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b10.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b11.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b12.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b13.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b14.GetComponent<Image>().color = new Color32(50, 50, 50, 255);
        b15.GetComponent<Image>().color = new Color32(0, 0, 0, 255);

    }

    public void Seleccionar15()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(false);
        tuto5.gameObject.SetActive(false);
        tuto6.gameObject.SetActive(false);
        tuto7.gameObject.SetActive(false);
        tuto8.gameObject.SetActive(false);
        tuto9.gameObject.SetActive(false);
        tuto10.gameObject.SetActive(false);
        tuto11.gameObject.SetActive(false);
        tuto12.gameObject.SetActive(false);
        tuto13.gameObject.SetActive(false);
        tuto14.gameObject.SetActive(false);
        tuto15.gameObject.SetActive(true);
        b1.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b2.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b3.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b4.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b5.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b6.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b7.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b8.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b9.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b10.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b11.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b12.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b13.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b14.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        b15.GetComponent<Image>().color = new Color32(50, 50, 50, 255);

    }

}
