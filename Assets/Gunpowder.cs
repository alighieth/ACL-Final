using System;
using System.Collections.Generic;
public class Gunpowder : Item
{
    private Dictionary<string, string> itemTypes = (Dictionary<string, string>)Inventory.getItemTypes();

    public Gunpowder(string type): base(type)
    {
        if (type == itemTypes.GetValueOrDefault("Normal_Gunpowder"))
        {
            this.buyPrice = 10;
            this.sellPrice = 5;
        }
        else if (type == this.itemTypes.GetValueOrDefault("High_Grade_Gunpowder"))
        {
            this.buyPrice = 20;
            this.sellPrice = 15;
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