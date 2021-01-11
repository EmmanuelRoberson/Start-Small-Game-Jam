using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamageOnScreenBehaviour : MonoBehaviour
{

    //Object to instantiate when pop up text needs to appear
    public GameObject PopupTextObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void RecieveDamageUpdate(float damage, Vector3 damageLocation)
    {
        GameObject instance = Instantiate(PopupTextObject, damageLocation, Quaternion.identity);
  
        instance.GetComponent<PopUpTextEffectBehaviour>().DoHopAndFade(damage, -1);
    }
}
