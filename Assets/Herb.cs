using System;
using System.Collections.Generic;
public class Herb : Item
{
    private Dictionary<string, string> itemTypes = (Dictionary<string, string>) Inventory.getItemTypes();
    public Herb(string type): base(type)
    {
        string GreenHerb = this.itemTypes.GetValueOrDefault("GreenHerb");
        if(type == GreenHerb)
        {
            this.buyPrice = 20;
            this.sellPrice = 15;
        } else if (type == this.itemTypes.GetValueOrDefault("RedHerb", " "))
        {
            this.buyPrice = 40;
            this.sellPrice = 25;
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