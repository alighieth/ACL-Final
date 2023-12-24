using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class Inventory : MonoBehaviour
{
    // UI Elements
    public Text healthText;
    public Text stasisText;
    public Text goldText;
    public Text knifeDurabilityText;
    public Text equippedWeaponText;
    public Text equippedGrenadeText;
    public Text selectedItemText;
    public Button equipButton;
    public Button useButton;
    public Button discardButton;
    public Button combineButton;

    // Inventory Constants
    private const int maxInventorySlots = 6;
    private const int startingPistolAmmo = 12;
    private const int startingTotalPistolAmmo = 12;

    // Player Stats
    private int healthPoints = 100;
    private int stasisPoints = 0;
    private int goldCoins = 0;
    private int knifeDurability = 100;

    // Inventory
    private Item[] inventory = new Item[maxInventorySlots];
    private Item equippedWeapon;
    private Item equippedGrenade;
    private Item selectedItem;
    private Item selectedItem2;

    public Dictionary<string, string> itemTypes = new Dictionary<string, string>
        {
            {"Emblem", "Emblem"},
            {"Key_Card", "Key Card"},
            {"Spade_Key", "Spade Key"},
            {"Heart_Key", "Diamond Key"},
            {"Club_Key", "Club Key"},
            {"Pistol", "Pistol"},
            {"Assault_Rifle", "Assault Rifle"},
            {"Shotgun", "Shotgun"},
            {"Revolver", "Revolver"},
            {"Hand_Grenade", "Hand Grenade"},
            {"Flash_Grenade", "Flash Grenade"},
            {"Normal_Gunpowder", "Normal Gunpowder"},
            {"High_Grade_Gunpowder", "High Grade Gunpowder"},
            {"Pistol_Ammo", "Pistol Ammo"},
            {"Assault_Rifle_Ammo", "Assault Rifle Ammo"},
            {"Shotgun_Ammo", "Shotgun Ammo"},
            {"Revolver_Ammo", "Revolver Ammo"},
            {"GoldBar", "Gold Bar"},
            {"Ruby", "Ruby"},
            {"Emerald", "Emerald"},
            {"Green_Green_Mixture", "Green Green Mixture"},
            {"Red_Red_Mixture", "Red Red Mixture"},
            {"GreenRedMixture", "Green Red Mixture"},
            {"GreenHerb", "Green Herb"},
            {"RedHerb", "Red Herb"},
            {"Single", "Single"},
            {"Automatic", "Automatic"},
            {"Medium", "Medium"},
            {"Short", "Short"},
            {"Long", "Long"},
        };

    // singleton
    private static Inventory instance;
    public static Inventory Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Inventory();
            }
            return instance;
        }
    }

    void Start()
    {
        
        Ammo pistolAmmo = new Ammo(itemTypes.GetValueOrDefault("Pistol_Ammo"), startingPistolAmmo);
        AddItemToInventory(new Weapon(itemTypes.GetValueOrDefault("Pistol"), pistolAmmo));
        AddItemToInventory(pistolAmmo);
        AddItemToInventory(new Herb(itemTypes.GetValueOrDefault("GreenHerb")));

        
        equipButton.onClick.AddListener(EquipSelectedItem);
        useButton.onClick.AddListener(UseSelectedItem);
        discardButton.onClick.AddListener(DiscardSelectedItem);
        

        
        UpdateUI();
    }

    
    private void UpdateUI()
    {
        // healthText.text = "Health: " + healthPoints;
        // stasisText.text = "Stasis: " + stasisPoints;
        // goldText.text = "Gold: " + goldCoins;
        // knifeDurabilityText.text = "Knife Durability: " + knifeDurability;

        // equippedWeaponText.text = "Equipped Weapon: " + (equippedWeapon != null ? equippedWeapon.name : "None");
        // equippedGrenadeText.text = "Equipped Grenade: " + (equippedGrenade != null ? equippedGrenade.name : "None");

        // if (selectedItem != null)
        // {
        //     selectedItemText.text = "Selected Item: " + selectedItem.name;

        //     equipButton.interactable = selectedItem is Weapon || selectedItem is Grenade;
        //     useButton.interactable = selectedItem is Herb;
        //     discardButton.interactable = !(selectedItem is Weapon) && !(selectedItem is KeyItem);
        // }
        // else
        // {
        //     selectedItemText.text = "Selected Item: None";
        //     equipButton.interactable = false;
        //     useButton.interactable = false;
        //     discardButton.interactable = false;
        // }
    }

    public void EquipSelectedItem()
    {
        if (selectedItem is Weapon)
        {
            equippedWeapon = selectedItem as Weapon;
        }
        else if (selectedItem is Grenade)
        {
            equippedGrenade = selectedItem as Grenade;
        }

        UpdateUI();
    }

    public bool isFull() {
        int count = 0;
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] != null)
            {
                count++;
            }
        }
        return count == maxInventorySlots;
    }

    public void UseSelectedItem()
    {
        if (selectedItem is Herb)
        {
           
            healthPoints = Mathf.Clamp(healthPoints, 0, 100);
            RemoveItemFromInventory(selectedItem);
        }

        UpdateUI();
    }

    public void DiscardSelectedItem()
    {
        RemoveItemFromInventory(selectedItem);
        UpdateUI();
    }

    public void Craft()
    {
        if (selectedItem != null && selectedItem2 != null)
        {
            
            Item craftedItem = CheckCraftingCombination(selectedItem, selectedItem2);

            if (craftedItem != null)
            {
               
                RemoveItemFromInventory(selectedItem);
                RemoveItemFromInventory(selectedItem2);

                
                AddItemToInventory(craftedItem);

                
                selectedItem = null;
                selectedItem2 = null;

               
                UpdateUI();
            }
            else
            {
                Debug.Log("Invalid combination");
            }
        }
        else
        {
            Debug.Log("Select two items to combine");
        }
    }

    private Item CheckCraftingCombination(Item item1, Item item2)
    {
        // Check for valid crafting combinations
        if ((item1.type == itemTypes.GetValueOrDefault("GreenHerb") && item2.type == itemTypes.GetValueOrDefault("GreenHerb")) || (item1.type == itemTypes.GetValueOrDefault("RedHerb") && item2.type == itemTypes.GetValueOrDefault("RedHerb")))
        {
            return new Mixture(itemTypes.GetValueOrDefault("Green_Green_Mixture"));
        }
        else if ((item1.type == itemTypes.GetValueOrDefault("GreenHerb") && item2.type == itemTypes.GetValueOrDefault("RedHerb")) || (item1.type == itemTypes.GetValueOrDefault("RedHerb") && item2.type == itemTypes.GetValueOrDefault("GreenHerb")))
        {
            return new Mixture(itemTypes.GetValueOrDefault("GreenRedMixture"));
        }
        else if (item1.type == itemTypes.GetValueOrDefault("Normal_Gunpowder") && item2.type == itemTypes.GetValueOrDefault("Normal_Gunpowder"))
        {
            return new Ammo(itemTypes.GetValueOrDefault("Pistol_Ammo"), 12);
        }
        else if (item1.type == itemTypes.GetValueOrDefault("Normal_Gunpowder") && item2.type == itemTypes.GetValueOrDefault("High_Grade_Gunpowder"))
        {
            return new Ammo(itemTypes.GetValueOrDefault("Shotgun_Ammo"), 8);
        }
        else if (item1.type == itemTypes.GetValueOrDefault("High_Grade_Gunpowder") && item2.type == itemTypes.GetValueOrDefault("High_Grade_Gunpowder"))
        {
            return new Ammo(itemTypes.GetValueOrDefault("Assault_Rifle_Ammo"), 30);
        }


        return null; 
    }

    public void AddItemToInventory(Item item)
    {
        if (item != null)
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == null)
                {
                    inventory[i] = item;
                    break;
                }
            }
        }
    }

    public void RemoveItemFromInventory(Item item)
    {
        if (item != null)
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == item)
                {
                    inventory[i] = null;
                    break;
                }
            }
        }
    }
}