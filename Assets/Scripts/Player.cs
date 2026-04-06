using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    public BaseStats stats;         
    private WeaponData weapon;
    public float range = 3f;
    public float moveSpeed = 5f;



    private void Awake()                               //EL OBJETO NAZCA CON ESOS DATOS YA PARAMETRIZADOS
    {
        stats = new BaseStats(10, 10, 5, 1, 20);
        weapon = new WeaponData("Pistol", 5);
    }

    void Start()
    {
        InvokeRepeating("AutoAttackEnemies", 1f, 1f);   //Metodo "InvokeRepeating", que se inicializara dsp de 1 segundo y suceder cada segundo.
    }

    void Update()
    {
        Movement();
    }
    public void TakeDamage(Enemy enemy) //Metodo para recibir daño de enemy
    {
        int enemyDamage = enemy.Weapon.WeaponDamage;
        stats.SetHealth(stats.Health - enemyDamage);
        Debug.Log("Has recibido" + enemyDamage + " de daño");
        Debug.Log("Vida restante" +  stats.Health);

        if (stats.Health <= 0)
        {
            Debug.Log(" Has muerto");
            Destroy(gameObject);
        }
    }
    public void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(x, y).normalized;

        transform.position += (Vector3)(direction * moveSpeed * Time.deltaTime);
    }

    public void SetWeapon(WeaponData weaponData)
    {
        weapon = weaponData;
    }


    public void AutoAttackEnemies() //Metodo para atacar enemigos
    {
        print("ATAQUE!");      //Para verificar el funcionamiento del metodo

        GameObject[] allEnemies = GameObject.FindGameObjectsWithTag("Enemy");   //crea variable local de objetos, y busca enemigos con el tag de enemy y los inserta dentro de esta variable 

        foreach (GameObject enemy in allEnemies)    //Recorre los objetos enemy dentro de la variable local allEnemies
        {
            float distance = Vector3.Distance(enemy.transform.position, transform.position); //crea variable local distance que calcula la distancia en el vector3 entre la posicion del enemigo y posicion local "player"

            if (distance <= range)  //si distancia es menor o igual a rango
                enemy.GetComponent<Enemy>().TakeDamage(this);   //busca enemy y obtiene su script Enemy, luego recibe daño de este local"player"
        }

    }
    public WeaponData Weapon => weapon;                //Getter para lectura en otros scripts

    private void OnDestroy()    //Metodo que al ser destruido el local "player", printea ...
    {
        Debug.Log("oh no me cancelaron");
    }
}
