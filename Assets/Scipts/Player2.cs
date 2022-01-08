using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public GameObject black;
    public GameObject control;
    public GameObject player2;
    public GameObject clear;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Button"))
        {
            Destroy(other.gameObject);
            black.SetActive(false);
            control.SetActive(true);
        }
        if (other.CompareTag("Clear"))
        {
            clear.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("L"))
        {
            player2.transform.position -= Vector3.right * 3f * Time.deltaTime;
        }
        if (other.CompareTag("R"))
        {
            player2.transform.position += Vector3.right * 3f * Time.deltaTime;
        }
        if (other.CompareTag("U"))
        {
            player2.transform.position += Vector3.forward * 3f * Time.deltaTime;
        }
        if (other.CompareTag("B"))
        {
            player2.transform.position -= Vector3.forward * 3f * Time.deltaTime;
        }
    }
}
