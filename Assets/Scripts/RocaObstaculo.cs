using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocaObstaculo : MonoBehaviour
{
    Animator m_animator;
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Agua2")
        {
            Debug.Log("me mojastes");
            GetComponent<Animator>().SetTrigger("Agua");
        }
    }
}
