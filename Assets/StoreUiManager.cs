using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreUiManager : MonoBehaviour
{

    GameObject popup;
    GameObject sellButton;
    GameObject buyButton;
    GameObject store;

    string currentChosenItem;
    void Start()
    {
        popup = GameObject.FindGameObjectWithTag("Popup");
        sellButton = GameObject.FindGameObjectWithTag("Sell");
        buyButton = GameObject.FindGameObjectWithTag("Buy");
        store = GameObject.FindGameObjectWithTag("Store");
        popup.SetActive(false);
        sellButton.SetActive(false);
        buyButton.SetActive(false);
    }

    public void OnStoreItemClick(string name)
    {
        currentChosenItem = name;
        popup.SetActive(true);
        if (name == "Rifle" || name == "Shotgun" || name == "Pistol Ammo" || name == "Rifle Ammo" || name == "Shotgun Ammo" || name == "Revolver Ammo")
        {
            buyButton.SetActive(true);
            return;
        }
        if (name == "Gold Bar" || name == "Ruby" || name == "Emerald" || name == "Green + Green" || name == "Red + Green" || name == "Red + Red") {
            sellButton.SetActive(true);
            return;
        }
        sellButton.SetActive(true);
        buyButton.SetActive(true);
    }

    public void handlePopupClicks(string name)
    {
        store.SetActive(false);
        popup.SetActive(false);
        sellButton.SetActive(false);
        buyButton.SetActive(false);
        // Item item = Item.createItem(currentChosenItem);
        
        if (name == "Buy")
        {
            // Store.Instance.buyItem(item, Player.Instance);
        }
        if (name == "Sell")
        {
            // Store.Instance.sellItem(item, Player.Instance);
        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            store.SetActive(false);
            popup.SetActive(false);
            sellButton.SetActive(false);
            buyButton.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            store.SetActive(true);
        }
    }
}
