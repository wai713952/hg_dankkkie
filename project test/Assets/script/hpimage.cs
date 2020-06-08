using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpimage : MonoBehaviour
{
    private CanvasGroup img;
    public float hpmax,hpreg,hitdamage;
    float hpupimg;
    bool hpholdimg;
    void Start()
    {
        img = GetComponent<CanvasGroup>();
    }

    IEnumerator hpdel()
    {
        yield return new WaitForSeconds(5);
        hpholdimg = false;
    }

    public void updatehp(float hp)
    {
        if(hp < 100)
        {
            hpholdimg = true;
        }
        if(hp >= 100){
            hp = hpmax;
            hpholdimg = false;
        }
        if(hpholdimg == true){
            StartCoroutine(hpdel());
            return;
        }
        if(hpholdimg == false){
            hp += hpreg * Time.deltaTime;
            Debug.Log(hp);
        }
        hpupimg = hp;
    }

    public void hpcanvas(CanvasGroup imgal)
    {
        imgal.alpha = 0 + (1 - (hpupimg*0.01f));
    }
}