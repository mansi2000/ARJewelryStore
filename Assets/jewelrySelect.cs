using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jewelrySelect : MonoBehaviour
{
    public GameObject bracelet;
    public GameObject ring;
    public GameObject earring;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void BraceletButtonClicked(){
        bracelet.SetActive(true);
        ring.SetActive(false);
        earring.SetActive(false);
    }
    public void RingButtonClicked(){
        bracelet.SetActive(false);
        ring.SetActive(true);
        earring.SetActive(false);
    }
    public void EarringButtonClicked(){
        bracelet.SetActive(false);
        ring.SetActive(false);
        earring.SetActive(true);
    }

    
}
