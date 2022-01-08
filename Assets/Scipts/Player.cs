using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    float hAxis;
    float vAxis;

    public GameObject black;
    public GameObject control;
    public GameObject player2;

    Vector3 moveVec;

    private void Update()
    {
        move();
    }
    void move()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
        moveVec = new Vector3(hAxis, 0, vAxis).normalized;
        transform.position += moveVec * speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Button"))
        {
            Destroy(other.gameObject);
            black.SetActive(false);
            control.SetActive(true);
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
