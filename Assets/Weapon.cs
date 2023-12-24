using System;
using System.Collections.Generic;
public class Weapon : Item
{
    Types.FiringMode firingMode {get; set;}
    Types.Range range {get; set;}
    int damage {get; set;}
    float timeBetweenShots {get; set;}
    Ammo ammo { get; set; }
    int clipCapacity { get; set; }
    
    public void initiateResources(string type) {
        switch (type)
        {
            case "Pistol":
                // ammoAmount = 12;
                // ammoType = Types.AmmoType.Pistol_Ammo_12;
                firingMode = Types.FiringMode.Single;
                damage = 2;
                timeBetweenShots = 0.2f;
                range = Types.Range.Medium;
                clipCapacity = 12;
                break;
            case "Assault Rifle":
                // ammoAmount = 30;
                // ammoType = Types.AmmoType.Assault_Rifle_Ammo_30;
                buyPrice = 150;
                firingMode = Types.FiringMode.Automatic;
                damage = 1;
                timeBetweenShots = 0.2f;
                range = Types.Range.Medium;
                clipCapacity = 30;
                break;
            case "Shotgun":
                // ammoAmount = 8;
                // ammoType = Types.AmmoType.Shotgun_Ammo_8;
                buyPrice = 140;
                firingMode = Types.FiringMode.Single;
                damage = 3;
                timeBetweenShots = 0.5f;
                range = Types.Range.Short;
                clipCapacity = 8;
                break;
            case "Revolver":
                // ammoAmount = 6;
                firingMode = Types.FiringMode.Single;
                damage = 5;
                timeBetweenShots = 1f;
                range = Types.Range.Long;
                clipCapacity = 6;
                break;
            default:
                break;
        }
    }

    public Weapon(string type, Ammo ammo): base(type)
    {
        this.ammo = ammo;
        initiateResources(type);
    }

    public bool shoot() {
        if(clipCapacity == 0) return false;
        clipCapacity--;
        return true;

    }

    public bool reload(string type) {
        if(type == "Pistol" && clipCapacity == 12)return false;
        if(type == "Assault Rifle" && clipCapacity == 30)return false;
        if(type == "Shotgun" && clipCapacity == 8)return false;
        if(type == "Revolver" && clipCapacity == 6)return false;
            switch(type){
                case "Pistol":
                // if(/*search for the weapon ammo*/) return false;
                clipCapacity = 12;
                return true;
                case "Assault Rifle":
                // if(/*search for the weapon ammo*/) return false;
                clipCapacity = 30;
                return true;
                case "Shotgun":
                // if(/*search for the weapon ammo*/) return false;
                clipCapacity = 8;
                return true;
                case "Revolver":
                // if(/*search for the weapon ammo*/) return false;
                clipCapacity = 6;
                return true;
                default:return false;
            }
    }
} 