using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SeedUI : MonoBehaviour
{
    public TextMeshProUGUI SeedUIText;
    public Inventory inventory;
   
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        SeedUIText = GameObject.FindGameObjectWithTag("SeedUI").GetComponent<TextMeshProUGUI>();
        
    }

    
    void Update()
    {
        SeedUIText.text = "Seed: "+ inventory.getSeed();
        
    }
}
