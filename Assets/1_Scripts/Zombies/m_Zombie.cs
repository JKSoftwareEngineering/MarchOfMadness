using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZombieObject;

public class m_Zombie : MonoBehaviour
{
    // Start is called before the first frame update
    public Zombie zombie = new Zombie();
    [SerializeField] private GameObject deadZedMale;
    [SerializeField] private GameObject deadZedFemale;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //zombie.Hit = false;
        if(!zombie.isAlive())
        {
            if(zombie.zedType == 0)
            {
                GameObject check = Instantiate(deadZedMale, transform.position, transform.rotation);
                if(transform.name.Equals("Dummy"))
                {
                    check.transform.name = "Dummy";
                }
            }
            if (zombie.zedType == 1)
            {
                Instantiate(deadZedFemale, transform.position, transform.rotation);
            }
            Destroy(gameObject);
        }
    }
}
