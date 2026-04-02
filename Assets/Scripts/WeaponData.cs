using UnityEngine;

public class WeaponData
{
    private string weaponName;
    private int weaponDamage;

    public WeaponData(string weaponName, int weaponDamage)
    {
        this.weaponName = weaponName;
        this.weaponDamage = weaponDamage;
    }

    public void SetWeaponName(string weaponName)
    {
        this.weaponName = weaponName;
    }
    public void SetWeaponDamage(int weaponDamage)
    {
        this.weaponDamage = weaponDamage;
    }


    public int WeaponDamage => weaponDamage;
    public string WeaponName => weaponName;
}