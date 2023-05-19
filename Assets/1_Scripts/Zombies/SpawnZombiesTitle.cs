using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombiesTitle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject ZombiePrefabMale;
    [SerializeField] private GameObject ZombiePrefabFemale;
    void Start()
    {
        for(int i = 0; i < 100; i++)
        {
            GameObject zombie = Instantiate(ZombiePrefabMale, new Vector3(transform.position.x + Random.Range(-5, 50f), 0, transform.position.z + Random.Range(-50, 50f)), ZombiePrefabMale.transform.rotation);
            zombie.name = "m" + i;
            zombie.gameObject.GetComponent<m_Zombie>().zombie.zedType = 0;
            zombie = Instantiate(ZombiePrefabFemale, new Vector3(transform.position.x + Random.Range(-200, 200f), 0, transform.position.z + Random.Range(-50, 50f)), ZombiePrefabFemale.transform.rotation);
            zombie.name = "f" + i;
            zombie.gameObject.GetComponent<m_Zombie>().zombie.zedType = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
