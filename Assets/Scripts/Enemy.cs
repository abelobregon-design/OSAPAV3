using UnityEngine;

public class Enemy : MonoBehaviour
{
    public BaseStats stats; 
    private void Awake()
    {
        stats = new BaseStats(10, 10, 5, 1, 20);  
    }
    void Start()
    {

    }
    void Update()
    {

    }
    public void TakeDamage(Player player)
    {
        int damage = player.Weapon.WeaponDamage;
    }
}