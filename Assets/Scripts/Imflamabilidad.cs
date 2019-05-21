using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imflamabilidad : MonoBehaviour
{
    public GameObject flamable,objeto;
    public int flamabilidad;

    private void OnTriggerEnter(Collider other)
    {
        if(flamabilidad==1)
        {
            if (other.tag == "Fuego" || other.tag == "Fuego2")
            {
                Debug.Log("me quemo");
                StartCoroutine(Quemarse());
            }
        }
        else if(flamabilidad==2)
        {
            if (other.tag == "Fuego2")
            {
                Debug.Log("me quemo2");
                StartCoroutine(Quemarse());
            }
        }

        
    }


    IEnumerator Quemarse()
    {
        flamable.gameObject.SetActive(true);
        yield return new WaitForSeconds(5);
        objeto.gameObject.SetActive(false);
    }
        

    // Update is called once per frame
    void Update()
    {
        
    }
}
