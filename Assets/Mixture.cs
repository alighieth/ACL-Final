using System;
using System.Collections.Generic;
public class Mixture : Item
{
    public Mixture(string type): base(type) 
    {
        switch (type)
        {
            case Inventory.itemTypes.GetValueOrDefault("Green_Green_Mixture"):
                sellPrice = 30;
                break;
            case Inventory.itemTypes.GetValueOrDefault("GreenRedMixture"):
                sellPrice = 20;
                break;
            case Inventory.itemTypes.GetValueOrDefault("Red_Red_Mixture"):
                sellPrice = 10;
                break;
            default:
                break;
        }
    }

    public void use() {
        switch (type)
        {
            case Inventory.itemTypes.GetValueOrDefault("Green_Green_Mixture"):
                sellPrice = 30;
                break;
            case Inventory.itemTypes.GetValueOrDefault("GreenRedMixture"):
                sellPrice = 20;
                break;
            case Inventory.itemTypes.GetValueOrDefault("Red_Red_Mixture"):
                sellPrice = 10;
                break;
            default:
                break;
        }
    }
}