using System;
using System.Collections.Generic;
public class Item
{
    public int buyPrice { get; set; }
    public int sellPrice { get; set; }
    public String type {get; set;}
    public Item(String type)
    {
        this.type = type;   
    }
}