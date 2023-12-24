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

    public void buyItem(Item item) {
        Inventory playerInventory = Inventory.Instance;
        if(Ammo.isAmmo(item.type))
        {
            playerInventory.stackAmmo(item);
            return;
        }

        if (playerInventory.gold < item.buyPrice || playerInventory.isFull() || playerInventory.containsItem(item.type) < 0)  
        {
            return;
        }

        playerInventory.gold -= item.buyPrice;
        playerInventory.AddItemToInventory(item);
    }

    
    public void sellItem(Item item) {
        Inventory playerInventory = Inventory.Instance;
        if(playerInventory.containsItem(item.type) < 0)
        {
            return;
        }
        playerInventory.gold += item.sellPrice;
        playerInventory.RemoveItemFromInventory(item);
    }
}