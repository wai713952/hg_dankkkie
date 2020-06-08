using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    //SerailizeField is used to kept variable's value inside its script
    [SerializeField] public float hitforceup;
    [SerializeField] public float hitforceback;
    public float hpmax,hitdamage,hpreg;
    public float hpup;
    private hpimage hp;
    [SerializeField] bool hphold = false;

    //OnCollisionEnter is condition that two object with rigid body and collider
//hit each other
    //(Collision ...) is specific function for OnCollisionEnter
    //(... hit) hit is variable name, works inside collision function;

    //hit.gameObject.name makes statements work after hit the object with 'specific name'
    //GetComponent<Rigidbody>() to enable .AddForce, we need to use this.
    //.AddForce add physical force to object include this component script
    //(transform...) make object mvoe in specific direction
        void OnCollisionEnter(Collision hit) {
            if(hit.gameObject.name == "damagebox")
            {
                GetComponent<Rigidbody>().AddForce(-transform.forward * hitforceback);
                GetComponent<Rigidbody>().AddForce(transform.up * hitforceup);
                hpup -= hitdamage;
                hphold = true;  
                StartCoroutine(hpdel());
                return;
                //hpimage.updatehp(hpup);
            }
        }

        IEnumerator hpdel()
        {
            yield return new WaitForSeconds(5);
            hphold = false;
        }

        void Update() {
            if(hphold == false){
            hpup += hpreg * Time.deltaTime;
            
            }
            if(hpup > 100){
                hpup = hpmax;
            }
            if(hpup <= 0){
                Destroy(gameObject);
            }
        }
}
