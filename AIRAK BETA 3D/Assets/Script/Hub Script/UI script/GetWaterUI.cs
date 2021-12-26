using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetWaterUI : MonoBehaviour
{
    public GameObject getWaterPrompt;
    public GameObject filledBucket;
    public Inventory inventory;
    
    
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        filledBucket.SetActive(false);
        getWaterPrompt.SetActive(false);

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" ) {
            getWaterPrompt.SetActive(true);
            filledBucket.SetActive(true);
            Debug.Log("Water got");
            inventory.setWater();
            
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            getWaterPrompt.SetActive(false);
        }
    }
    private void Update()
    {
        if (inventory.getWater() < 1)
        {
            filledBucket.SetActive(false);
        }
    }
}
