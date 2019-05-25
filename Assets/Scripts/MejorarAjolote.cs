using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MejorarAjolote : MonoBehaviour
{
    public RectTransform especialA, especialF, especialN, orbeA, orbeF, orbeN;
    RectTransform espacioAjolote, espacioOrbe;

    bool ajoAI, ajoFI, ajoNI, orbeAI, orbeFI, orbeNI;
    MenuInventario conexMI;
    // Start is called before the first frame update
    void Start()
    {
        conexMI = GameObject.Find("InventarioUI").GetComponent<MenuInventario>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MejorarAgua()
    {
        espacioAjolote = GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(0).GetComponent<RectTransform>();
        espacioOrbe = GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(1).GetComponent<RectTransform>();

        foreach (var iterador in conexMI.herramientas)
        {
            if (iterador.Is_used)
            {
                if (iterador.RealItemName == "AjoloteSAgua")
                {
                    ajoAI = true;
                }
            }
        }

        //Condicion para ajolote
        if (ajoAI)
            Instantiate(especialA, espacioAjolote.transform);

        //Condicion para orbe
        if (true)
            Instantiate(orbeA, espacioOrbe.transform);
    }

    public void MejorarFuego()
    {
        espacioAjolote = GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(0).GetComponent<RectTransform>();
        espacioOrbe = GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(1).GetComponent<RectTransform>();
        
        //Condicion para ajolote
        if (true)
            Instantiate(especialF, espacioAjolote.transform);

        //Condicion para orbe
        if (true)
            Instantiate(orbeF, espacioOrbe.transform);
    }

    public void MejorarNube()
    {
        espacioAjolote = GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(0).GetComponent<RectTransform>();
        espacioOrbe = GameObject.Find("AjoYOrbe").GetComponent<RectTransform>().GetChild(1).GetComponent<RectTransform>();

        //Condicion para ajolote
        if(true)
            Instantiate(especialN, espacioAjolote.transform);

        //Condicion para orbe
        if(true)
            Instantiate(orbeN, espacioOrbe.transform);
    }
}
