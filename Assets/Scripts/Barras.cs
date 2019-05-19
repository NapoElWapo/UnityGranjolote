using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Barras : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Image barra;
    public int tipoDeBarra;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(tipoDeBarra==1)
        {
            ValorBarra();
        }
        else if(tipoDeBarra==2)
        {

        }
        
    }

    private void ValorBarra()
    {
        GameObject Jugador = GameObject.FindWithTag("Player");
        FirstPersonController playerScript = Jugador.GetComponent<FirstPersonController>();
        barra.fillAmount = playerScript.stamina*.01f;
    }
}
