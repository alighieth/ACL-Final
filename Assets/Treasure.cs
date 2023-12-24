using System;
using System.Collections.Generic;
public class Treasure : Item
{
    public Treasure(string type): base(type)
    {
        switch (type)
        {
            case Inventory.itemTypes.GetValueOrDefault("GoldBar"):
                sellPrice = 100;
                break;
            case Inventory.itemTypes.GetValueOrDefault("Ruby"):
                sellPrice = 200;
                break;
            case Inventory.itemTypes.GetValueOrDefault("Emerald"):
                sellPrice = 300;
                break;
            default:
                break;
        }
    }
    
}