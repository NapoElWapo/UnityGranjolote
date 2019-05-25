using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porton : MonoBehaviour
{
    Animator m_animator;
    LogrosYMisiones conexLM;
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (conexLM.m10c)
        {
           
            GetComponent<Animator>().SetTrigger("Abrir");
        }
    }
}
