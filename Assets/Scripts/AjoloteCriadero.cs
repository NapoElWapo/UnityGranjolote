using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoloteCriadero : MonoBehaviour
{

    RectTransform slotActual;
    public RectTransform ajoloteCriadero;
    public RectTransform nuevoSlot;
    int slot = 0;
    string nombreSlot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dejarAjolote()
    {
        if(slot<10)
        {
        slotActual = GameObject.Find("AjoloteSlotC (" + slot + ")").GetComponent<RectTransform>();
        Instantiate(ajoloteCriadero, slotActual.transform);
        slot++;
        Debug.Log("Se dejo un ajolote");
        }
    }

    public void recogerAjolote()
    {
        if(slot>0)
        {
        slot--;
        slotActual = GameObject.Find("AjoloteSlotC (" + slot + ")").GetComponent<RectTransform>();
        Destroy(GameObject.Find("AjoloteSlotC (" + slot + ")").GetComponent<RectTransform>().GetChild(2).gameObject);
            
        }
    }
}
