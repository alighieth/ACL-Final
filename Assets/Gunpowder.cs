using System;
using System.Collections.Generic;
public class Gunpowder : Item
{
    public Gunpowder(string type): base(type)
    { 
        switch (type)
        {
            case Inventory.itemTypes.GetValueOrDefault("Normal_Gunpowder"):
                buyPrice = 10;
                sellPrice = 5;
                break;
            case Inventory.itemTypes.GetValueOrDefault("High_Grade_Gunpowder"):
                buyPrice = 20;
                sellPrice = 15;
                break;
            default:
                break;
        }
    }
    
    // public Types.AmmoType crafting(Types.GunpowderType type1, Types.GunpowderType type2){
    //     if(type1 ==  Types.GunpowderType.Normal_Gunpowder && type2 == Types.GunpowderType.Normal_Gunpowder){
    //         return Types.AmmoType.Pistol_Ammo_12;
    //     }
    //     else if(type1 ==  Types.GunpowderType.Normal_Gunpowder && type2 == Types.GunpowderType.High_Grade_Gunpowder){
    //         return Types.AmmoType.Shotgun_Ammo_8;
    //     }
    //     else if(type1 ==  Types.GunpowderType.High_Grade_Gunpowder && type2 == Types.GunpowderType.High_Grade_Gunpowder){
    //         return Types.AmmoType.Assault_Rifle_Ammo_30;
    //     }
    //     return Types.AmmoType.Pistol_Ammo_12;
    // }


}