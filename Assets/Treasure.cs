using System;
using System.Collections.Generic;
public class Treasure : Item
{
    private Dictionary<string, string> itemTypes = (Dictionary<string, string>)Inventory.getItemTypes();

    public Treasure(string type): base(type)
    {

        if (type == itemTypes.GetValueOrDefault("GoldBar"))
        {
            this.sellPrice = 100;
        }
        else if (type == itemTypes.GetValueOrDefault("Ruby"))
        {
            this.sellPrice = 200;
        }
        else if (type == itemTypes.GetValueOrDefault("Emerald"))
        {
            this.sellPrice = 300;
        }
    }
    
}