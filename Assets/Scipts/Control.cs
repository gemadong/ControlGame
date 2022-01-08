using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    Renderer ren;
    Material matThis;
    private void Start()
    {
        ren = GetComponent<Renderer>();
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ren.material.color = Color.gray;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ren.material.color = Color.black;
        }
    }
}
