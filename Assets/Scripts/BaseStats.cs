using UnityEngine;

public class BaseStats      
{
    private int power;          //VARIABLES PRIVADAS
    private int speed;
    private int health;
    private int knockback;
    private int xp;
    public BaseStats(int health, int power, int speed, int knockback, int xp) //CONSTRUCTOR PARAMETRIZADO
    {
        this.health = health;           //INDICA QUE SERA EL NUEVO VALOR REAL DE LA VARIABLE
        this.power = power;
        this.speed = speed;
        this.knockback = knockback;
        this.xp = xp;
    }
    public void SetPower(int power)    //METODO PARA CAMBIAR EL VALOR REAL DE LA VARIABLE
    {
        this.power = power;
    }
    public void SetSpeed(int speed)
    {
        this.speed = speed;
    }

    public void SetHealth(int health)
    {
        this.health = health;
    }
    public void SetKnockback(int knockback)
    {
        this.knockback = knockback;
    }
    public void SetXP(int xp)
    {
        this.xp = xp;
    }
    public int Power => power;              //PONER PUBLICA LA LECTURA DE LA VARIABLE Y POR CONSIGUIENTE EL PODER LEERLO EN OTRAS CLASES.
    public int Health => health;
    public int Knockback => knockback;
    public int XP => xp;
    public int Speed => speed;

}