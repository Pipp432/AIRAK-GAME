using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    Inventory inventory;
    public GameObject crop;
    Transform farmland;
    void Start()
    {
        inventory = gameObject.GetComponent<Inventory>();      
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "WateredFarmland" && inventory.seed>0) {
            farmland = other.GetComponent<Transform>();
            Instantiate(crop, farmland.position+new Vector3(0,-0.5f,0), Quaternion.identity);
            inventory.useSeed(1);
            Debug.Log("Planted");
            other.tag = "PlantedFarmLand";
            
        }
        
    }
    
}
