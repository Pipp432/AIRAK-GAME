using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenShop : MonoBehaviour
{
    public GameObject itemShopUI;
    public GameObject floatingTextPrefab;

    private void Start()
    { 
        itemShopUI.SetActive(false);
        FloatingText();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {

            itemShopUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            
            Cursor.lockState = CursorLockMode.Locked;
        {
            itemShopUI.SetActive(false);
        }
    }
   
    private void FloatingText() {
        Instantiate(floatingTextPrefab, transform.position+ new Vector3(0,2,0),transform.rotation, transform);
    }
}
