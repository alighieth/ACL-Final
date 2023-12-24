using System;
using System.Collections.Generic;
public class Ammo : Item
{
    public int  ammoAmount;
    private Dictionary<string, string> itemTypes = (Dictionary<string, string>)Inventory.getItemTypes();

    public Ammo(string type, int ammout): base(type)
    {
        this.ammoAmount = ammout;

        if (type == this.itemTypes.GetValueOrDefault("Pistol_Ammo"))
        {
            this.buyPrice = 30;
        }
        else if (type == this.itemTypes.GetValueOrDefault("Assault_Rifle_Ammo"))
        {
            this.buyPrice = 50;
        }
        else if (type == this.itemTypes.GetValueOrDefault("Shotgun_Ammo"))
        {
            this.buyPrice = 40;
        }
        else if (type == this.itemTypes.GetValueOrDefault("Revolver_Ammo"))
        {
            this.buyPrice = 70;
        }
      
    }

    public static bool isAmmo(string itemType)
    {
        return itemType.Contains("Ammo", StringComparison.OrdinalIgnoreCase);
    }
    
}