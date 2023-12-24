using System;
using System.Collections.Generic;
public class Grenade : Item
{
    private Dictionary<string, string> itemTypes = (Dictionary<string, string>)Inventory.getItemTypes();

    public Grenade(string type): base(type)
    {
        if (type == itemTypes.GetValueOrDefault("Hand_Grenade"))
        {
            this.buyPrice = 15;
            this.sellPrice = 10;
        }
        else if (type == itemTypes.GetValueOrDefault("Flash_Grenade"))
        {
            this.buyPrice = 15;
            this.sellPrice = 10;
        }
        
    }
    
}