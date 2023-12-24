using System;
using System.Collections.Generic;
public class Herb : Item
{
    public Herb(string type): base(type)
    {
        switch (type) {
            case Inventory.itemTypes.GetValueOrDefault("GreenHerb"):
                buyPrice = 20;
                sellPrice = 15;
                break;
            case Inventory.itemTypes.GetValueOrDefault("RedHerb"):
                buyPrice = 40;
                sellPrice = 25;
                break;
            default:
                break;
        }
    }

    

    // public Types.MixtureType crafting(Types.HerbType type1,Types.HerbType type2){
    //     if(type1 ==  Types.HerbType.Green_Herb && type2 == Types.HerbType.Green_Herb){
    //         return Types.MixtureType.Green_Green_Mixture;
    //     }
    //     else if(type1 ==  Types.HerbType.Green_Herb && type2 == Types.HerbType.Red_Herb){
    //         return Types.MixtureType.Green_Red_Mixture;
    //     }
    //     else if(type1 ==  Types.HerbType.Red_Herb && type2 == Types.HerbType.Red_Herb){
    //         return Types.MixtureType.Red_Red_Mixture;
    //     }
    //     return Types.MixtureType.Green_Green_Mixture;
    // }

    public void use() {
        // only adding using of green herb
        // if(herbType == Types.HerbType.Green_Herb) {
            // GAIN 2 health points
        // }
    }
}