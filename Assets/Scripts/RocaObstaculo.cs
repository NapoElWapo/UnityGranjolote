using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocaObstaculo : MonoBehaviour
{
    // Start is called before the first frame update

    Animator m_animator;
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
