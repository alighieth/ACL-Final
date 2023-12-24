using System;
using System.Collections.Generic;
public class Mixture : Item
{
    private Dictionary<string, string> itemTypes = (Dictionary<string, string>)Inventory.getItemTypes();
    public Mixture(string type): base(type) 
    {

        if(type == itemTypes.GetValueOrDefault("Green_Green_Mixture"))
        {
            this.sellPrice = 30;
        } else if(type == itemTypes.GetValueOrDefault("GreenRedMixture"))
        {
            this.sellPrice = 20;
        } else if(type == itemTypes.GetValueOrDefault("Red_Red_Mixture"))
        {
            this.sellPrice = 10;
        }
        
    }

    public void use() {

      
        //switch (type)
        //{
        //    case itemTypes.GetValueOrDefault("Green_Green_Mixture"):
        //        sellPrice = 30;
        //        break;
        //    case itemTypes.GetValueOrDefault("GreenRedMixture"):
        //        sellPrice = 20;
        //        break;
        //    case itemTypes.GetValueOrDefault("Red_Red_Mixture"):
        //        sellPrice = 10;
        //        break;
        //    default:
        //        break;
        //}
    }
}