using System;
using System.Collections.Generic;
public class Grenade : Item
{
    public Grenade(string type): base(type)
    {
        switch (type)
        {
            case Inventory.itemTypes.GetValueOrDefault("Hand_Grenade"):
                buyPrice = 15;
                sellPrice = 10;
                break;
            case Inventory.itemTypes.GetValueOrDefault("Flash_Grenade"):
                buyPrice = 15;
                sellPrice = 10;
                break;
            default:
                break;
        }
    }
    
}