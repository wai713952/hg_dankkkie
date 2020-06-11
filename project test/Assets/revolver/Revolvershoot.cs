using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Revolvershoot : MonoBehaviour
{
public GameObject bulletline;
private Animator Gun;
public  float ammo = 6;
public static bool shoot ;

    void Start()
    {
        Gun = GetComponent<Animator>();
        shoot = false;
        bulletline.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)&& ammo > 0)
        {
            Gun.SetBool("shoot",true);
        }
        if(Input.GetKeyUp(KeyCode.Mouse0)&& ammo > 0)
        {
            Gun.SetBool("shoot",false);
        }
     
    }
    void shooting()
    {
        shoot = true;
        bulletline.SetActive(true);
        ammo--;
    Debug.Log(shoot);
    }
    void endshooting(){
        shoot = false;
        bulletline.SetActive(false);
    }
    IEnumerator bulletlie()
    {
        yield return new WaitForSeconds(0.5f);
    }
   
    
}