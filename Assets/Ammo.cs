using System;
using System.Collections.Generic;
public class Ammo : Item
{
    int  ammoAmount;
    public Ammo(string type, int ammout): base(type)
    {
        this.ammoAmount = ammout;
        switch (type)
        {
            case Inventory.itemTypes.GetValueOrDefault("Pistol_Ammo"):
                buyPrice = 30;
                break;
            case Inventory.itemTypes.GetValueOrDefault("Assault_Rifle_Ammo"):
                buyPrice = 50;
                break;
            case Inventory.itemTypes.GetValueOrDefault("Shotgun_Ammo"):
                buyPrice = 40;
                break;
            case Inventory.itemTypes.GetValueOrDefault("Revolver_Ammo"):
                buyPrice = 70;
                break;
            default:
                break;
        }
    }
    
}