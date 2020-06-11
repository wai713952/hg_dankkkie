using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolvershoot : MonoBehaviour
{
private Animator Gun;
public static float ammo = 6;

    void Start()
    {
        Gun = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)&& ammo > 0)
        {
            Gun.SetBool("shoot",true);
            ammo--;
        }
        if(Input.GetKeyUp(KeyCode.Mouse0)&& ammo > 0)
        {
            Gun.SetBool("shoot",false);
        }
    }
}