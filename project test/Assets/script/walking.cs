using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    [SerializeField] public float speed;


    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward*Time.deltaTime*speed);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back*Time.deltaTime*speed);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right*speed*Time.deltaTime);
        }
    }
}
