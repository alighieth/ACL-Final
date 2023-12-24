using System;
using System.Collections.Generic;

public class Player
{
    public int gold;
    public Inventory inventory;

    private static Player instance;

    private Player() {
        gold = 100;
        inventory = Inventory.Instance;
    }

    public static Player Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Player();
            }
            return instance;
        }
    }
}