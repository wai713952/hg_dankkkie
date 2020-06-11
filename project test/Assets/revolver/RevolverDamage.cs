using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolverDamage : MonoBehaviour
{
[SerializeField] float enemyhp = 6;
[SerializeField] public float enemyhitforceback;
[SerializeField] public float enemyhitforceup;
void OnTriggerStay(Collider bullet) 
    {
        if(bullet.gameObject.name == "bulletline")
            {
                if(Input.GetKeyDown(KeyCode.Mouse0) && Revolvershoot.ammo > 0)
                {
                    GetComponent<Rigidbody>().AddForce(-transform.forward * enemyhitforceback);
                    GetComponent<Rigidbody>().AddForce(transform.up * enemyhitforceup);

                    enemyhp--;
                    if(enemyhp <= 0)
                        {
                            Destroy(gameObject);
                        }
                    Debug.Log(enemyhp);
                }
                
            }
    }
}