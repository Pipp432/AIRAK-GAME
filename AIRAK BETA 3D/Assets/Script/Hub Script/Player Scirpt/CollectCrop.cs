using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCrop : MonoBehaviour, IHarvestable
{
    public Crop crop;
    public bool collectable = false;
    public Inventory inventory;
    public GameObject farmland;
    public FarmlandState farmlandState;
    bool fullyGrown = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Crop") {
            crop = other.GetComponent<Crop>();
            collectable = true;
            fullyGrown = true;
            Collect();
            }

        if (other.tag == "PlantedFarmLand" && fullyGrown)
        { 
            other.tag = "WateredFarmland";
            fullyGrown = false;
        }
    }
    public void Collect()
    {
        if (collectable)
        {

            Destroy(crop.gameObject);
            inventory.addMoney(10);
        }
    }
}
