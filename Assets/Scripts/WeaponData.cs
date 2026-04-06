using UnityEngine;

public class WeaponData
{
    private string weaponName; //VARIABLES PRIVADAS
    private int weaponDamage;

    public WeaponData(string weaponName, int weaponDamage) //CONSTRUCTOR
    {
        this.weaponName = weaponName;
        this.weaponDamage = weaponDamage;
    }

    public void SetWeaponName(string weaponName)  //CAMBIAR VALOR
    {
        this.weaponName = weaponName;
    }
    public void SetWeaponDamage(int weaponDamage)  //CAMBIAR VALOR
    {
        this.weaponDamage = weaponDamage;
    }


    public int WeaponDamage => weaponDamage; //PARA LECTURA DEBUG.LOG
    public string WeaponName => weaponName; //PARA LECTURA DEBUG.LOG
}