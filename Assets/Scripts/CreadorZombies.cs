using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CreadorZombies : MonoBehaviour
{
    public GameObject ZombiesFemale;
    public float tiempoCreacion = 2f;
    public float rangoCreacion = 2f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Creando", 0.0f, tiempoCreacion);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Creando()
    {
       
        
       // Vector3 SpawnPosition = new Vector3(0, 0,0);
        //SpawnPosition = this.transform.position + Random.onUnitSphere * rangoCreacion;
       //SpawnPosition = new Vector3(SpawnPosition.x, SpawnPosition.y, 0);
      // var position = new Vector2(transform.position.x - 2.5f * rangoCreacion, transform.position.y - .5f);
       
      // Instantiate(ZombiesFemale, position, ZombiesFemale.transform.rotation);
       // GameObject Zombie = Instantiate(ZombiesFemale, position, Quaternion.identity);
    }
}
