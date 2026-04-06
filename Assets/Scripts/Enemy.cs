using UnityEngine;

public class Enemy : MonoBehaviour
{
    public BaseStats stats; 
    private WeaponData weapon;
    public float moveSpeed = 2f;
    private Transform playerTarget;

    private void Awake()                            //VALORES PARAMETRIZADOS CON LOS QUE NACERA EL OBJETO
    {
        stats = new BaseStats(10, 10, 5, 1, 20);
        weapon = new WeaponData("Cuchillo", 5);
    }
    void Start()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");

        if (playerObj != null)
        {
            playerTarget = playerObj.transform;
        }
    }
    void Update()
    {
        ChasePlayer();
    }

    public void ChasePlayer()
    {
        if (playerTarget == null) return;

        transform.position = Vector2.MoveTowards(transform.position, playerTarget.position, moveSpeed * Time.deltaTime);

    }

    public void TakeDamage(Player player)   //Metodo para recibir daño de Player
    {
        int damage = player.Weapon.WeaponDamage;    //variable damage viene a ser el daño del arma de player.
        stats.SetHealth(stats.Health - damage); //vamos a cambiar la vida local, y le restamos el daño de player

        Debug.Log("Enemy recibió " +  damage + " de daño");
        Debug.Log("Vida restante " + stats.Health);

        if (stats.Health <= 0)
        {
            Debug.Log("Enemigo muerto");
            Destroy(gameObject);
        }
    }
    public WeaponData Weapon => weapon;
    private void OnDestroy()
    {
        Debug.Log("Enemigo eliminado");
    }
   
   
}