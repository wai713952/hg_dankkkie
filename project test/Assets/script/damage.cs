using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damage : MonoBehaviour
{
    public  Image image;

    private Color tempColor;
    

     
   
    //SerailizeField is used to kept variable's value inside its script
    [SerializeField] public float hitforceup;
    [SerializeField] public float hitforceback;
    public float hpmax,hitdamage,hpreg;
    public float hpup;
    private hpimage hp;
    [SerializeField] bool hphold = false;

    

      void Start() 
     {
        tempColor = image.color;
        tempColor.a = 0f;
        image.color = tempColor;
          
          
    }

    
   

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
                tempColor = image.color;
                 tempColor.a +=hitdamage/100;
                 image.color = tempColor;
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
            tempColor = image.color;
                 tempColor.a -=(hpreg/100)*Time.deltaTime;
                 image.color = tempColor;
           
            }
            if(hpup > 100){
               tempColor = image.color;
                 tempColor.a =0f;
                 image.color = tempColor;
                hpup = hpmax;
            }
            if(hpup <= 0){
                Destroy(gameObject);
            }
        }
        
}
