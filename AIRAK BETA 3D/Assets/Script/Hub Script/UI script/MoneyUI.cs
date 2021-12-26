using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyUI : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Inventory playerInventory;
    void Start()
    {
        
        text.text = "Money: 0";
    }

   
    void Update()
    {
        text.text = "Money: " + playerInventory.getMoney();
    }
}
