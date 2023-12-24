public class Types
{
    public enum ItemType
    {
        Weapon,
        Grenade,
        Gunpowder,
        Ammo,
        Treasure,
        Mixture,
        Herb, 
        Key
    }

    public enum KeyItems {
        Emblem,
        Key_Card, 
        Spade_Key,
        Heart_Key,
        Diamond_Key,
        Club_Key
    }

   public enum WeaponType
    {
        Pistol,
        Assault_Rifle,
        Shotgun,
        Revolver,
    }
    
    public enum GrenadeType
    {
       Hand_Grenade,
       Flash_Grenade
    }

    public enum GunpowderType
    {
       Normal_Gunpowder,
       High_Grade_Gunpowder
    }

    public enum AmmoType
    {
        Pistol_Ammo_12,
        Assault_Rifle_Ammo_30,
        Shotgun_Ammo_8,
        Revolver_Ammo_6
    }

    public enum TreasureType
    {
        Gold_Bar,
        Ruby,
        Emerald,
    }

    public enum MixtureType
    {
        Green_Green_Mixture,
        Green_Red_Mixture,
        Red_Red_Mixture
    }

    public enum HerbType
    {
        Green_Herb,
        Red_Herb,
    }

    public enum FiringMode {
        Automatic,
        Single
    }

    public enum Range {
        Medium, 
        Short,
        Long
    }
}