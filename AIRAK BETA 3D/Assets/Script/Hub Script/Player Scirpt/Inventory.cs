using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int money;
    public int water;
    public int seed;

    private void Start()
    {
        money = 0;
        seed = 5;
    }

    public int getMoney()
    {
        return this.money;
    }
    public int getWater() {
        return this.water;
    }
    public void addMoney(int amount)
    {
        money = getMoney() + amount;
        
    }
    public void removeMoney(int amount)
    {
        money = getMoney() - amount;
        
    }
    public void useWater(int amount) {
        water = getWater() - amount;
    }
    public void addWater(int amount) {
        water = getWater() + amount;
    }
    public void setWater() {
        this.water = 5;
    }
    public int getSeed() {
        return this.seed;
    }
    public void useSeed(int amount)
    {
        seed = getSeed() - amount;
    }

    public void addSeed(int amount)
    {
        seed = getSeed() + amount;
    }
}
