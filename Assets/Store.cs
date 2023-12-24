using System;
using System.Collections.Generic;
public class Store
{
    private static Store instance;
    public List<Item> items;

    private Store() {
        items = new List<Item>();
    }

    public static Store Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Store();
            }
            return instance;
        }
    }

    public void buyItem(Item item, Player player) {
        if (player.gold < item.buyPrice || player.inventory.isFull())  
        {
            return;
        }
        player.gold -= item.buyPrice;
        player.inventory.AddItemToInventory(item);
    }

    
    public void sellItem(Item item, Player player) {
        player.gold += item.sellPrice;
        player.inventory.RemoveItemFromInventory(item);
    }
}