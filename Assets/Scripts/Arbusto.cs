using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbusto : MonoBehaviour
{

    Animator m_animator;
    
    private float ex,ey,ez,animador;
    public GameObject arbusto;
    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
        Debug.Log("arbustingin");
        ex = arbusto.transform.localScale.x;
        Debug.Log(ex);
        ey = arbusto.transform.localScale.y;
        Debug.Log(ey);
        ez = arbusto.transform.localScale.z;
        Debug.Log(ez);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            
            animador += Time.deltaTime;

            if (animador < 0.0666f)
            {
                
                arbusto.transform.localScale = new Vector3(ex * 0.9906f, ey * 0.9906f, ez * 0.9906f);
            }
            else if (animador < 0.1332f && animador > 0.0666f)
            {
                arbusto.transform.localScale = new Vector3(ex * 0.9758f, ey * 0.9758f, ez * 0.9758f);
            }
            else if (animador < 0.1998f && animador > 0.1332f)
            {
                arbusto.transform.localScale = new Vector3(ex * 0.9598f, ey * 0.9598f, ez * 0.9598f);
            }
            else if (animador < 0.2664f && animador > 0.1998f)
            {
              
                arbusto.transform.localScale = new Vector3(ex * 0.9496f, ey * 0.9496f, ez * 0.9496f);
            }
            else if (animador < 0.333f && animador > 0.2664f)
            {
                arbusto.transform.localScale = new Vector3(ex * 0.9438f, ey * 0.9415f, ez * 0.9415f);
            }
            else if (animador < 0.3996f && animador > 0.333f)
            {
                arbusto.transform.localScale = new Vector3(ex * 0.9539f, ey * 0.9430f, ez * 0.9430f);
            }
            else if (animador < 0.4662f && animador > 0.3996f)
            {
                arbusto.transform.localScale = new Vector3(ex * 0.9773f, ey * 0.9485f, ez * 0.9485f);
            }
            else if (animador < 0.5328f && animador > 0.4662f)
            {
                arbusto.transform.localScale = new Vector3(ex * 1.0079f, ey * 0.9556f, ez * 0.9556f);
            }
            else if (animador < 0.5994f && animador > 0.5328f)
            {
                arbusto.transform.localScale = new Vector3(ex * 1.034f, ey * 0.9634f, ez * 0.9634f);
            }
            else if (animador < 0.666f && animador > 0.5994f)
            {
                arbusto.transform.localScale = new Vector3(ex * 1.0464f, ey * 0.9709f, ez * 0.9709f);
            }
            else if (animador < 0.7326f && animador > 0.666f)
            {
                arbusto.transform.localScale = new Vector3(ex * 1.0439f, ey * 0.9780f, ez * 0.9780f);
            }
            else if (animador < 0.7992f && animador > 0.7326f)
            {
                arbusto.transform.localScale = new Vector3(ex * 1.0339f, ey * 0.9854f, ez * 0.9854f);
            }
            else if (animador < 0.8658f && animador > 0.7992f)
            {
                arbusto.transform.localScale = new Vector3(ex * 1.0205f, ey * 0.9919f, ez * 0.9919f);
            }
            else if (animador < 0.9324f && animador > 0.8658f)
            {
           
                arbusto.transform.localScale = new Vector3(ex * 1.0078f, ey * 0.9965f, ez * 0.9965f);
            }
            else if (animador < 0.999f && animador > 0.9324f)
            {
                arbusto.transform.localScale = new Vector3(ex, ey, ez);
            }
            else if (animador >= 1)
            {
                animador = 0;
            }



        }
        
    }
    
}
