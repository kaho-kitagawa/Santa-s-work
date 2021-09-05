using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaMove : MonoBehaviour
{
    public float speed = 7.0f;
    public GameObject PresentBox;

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(PresentBox, transform.position, Quaternion.identity);
        }
    }
}