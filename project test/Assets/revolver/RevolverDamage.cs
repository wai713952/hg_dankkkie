using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolverDamage : MonoBehaviour
{
    public GameObject enemy ;
[SerializeField] float enemyhp = 6;
[SerializeField] public float enemyhitforceback;
[SerializeField] public float enemyhitforceup;
void OnTriggerEnter(Collider bullet) 
    {
        if(bullet.gameObject.name == "bulletline")
            {
                if(Revolvershoot.shoot==true)
                {
                   enemy.GetComponent<Rigidbody>().AddForce(-transform.forward * enemyhitforceback);
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