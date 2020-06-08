using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    [SerializeField] public float mousespeed;
    public Transform playerbody;
    float Xrotate = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mousespeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mousespeed * Time.deltaTime;

        Xrotate -= mouseY;
        Xrotate = Mathf.Clamp(Xrotate, -90f,90f);

        //transform ใช้ย้าย หมุน ขยาย object
        //.local คือ เปลี่ยนไปตาม parent
        transform.localRotation = Quaternion.Euler(Xrotate, 0f, 0f);
        playerbody.Rotate(Vector3.up * mouseX);
    }
}
