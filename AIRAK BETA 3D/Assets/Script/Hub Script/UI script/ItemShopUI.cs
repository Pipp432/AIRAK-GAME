using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemShopUI : MonoBehaviour
{
    public GameObject itemUI;
    public Button[] btnArr;
    Inventory playerInventory;

    private void Start()
    {
        itemUI.SetActive(false);
    }
    private void Awake()
    {
        playerInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        btnArr[0].onClick.AddListener(DeducMoney);
        
    }

    
    void DeducMoney()
    {
        if (playerInventory.getMoney() > 0)
        {
            playerInventory.removeMoney(5);
            playerInventory.addSeed(1);
        }
    }
        
        
}