using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierShoot : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] Zombies;
    //private GameObject PirmaryTarget;
    private float furthest = 40;
    private int target = 0;
    [SerializeField] private GameObject bloodHit;
    private float autoRifleTimer = 0f;
    private float autoRifleTimerMax = .2f;
    [SerializeField] private float rotationSpeed = 4f;
    [SerializeField] bool IsOpening = false;
    [SerializeField] private GameObject PistolShot;
    [SerializeField] private GameObject muzzelFlash;
    void Start()
    {
        autoRifleTimerMax = Random.Range(.1f, .4f);
        autoRifleTimer = Random.Range(0, autoRifleTimerMax);
    }

    // Update is called once per frame
    void Update()
    {
        muzzelFlash.SetActive(false);
        furthest = 40f;
        target = 0;
        autoRifleTimer += Time.deltaTime;
        Zombies = GameObject.FindGameObjectsWithTag("Zombie");
        if (Zombies.Length > 0)
        {
            if (autoRifleTimer >= autoRifleTimerMax)
            {
                for(int i = 0; i < Zombies.Length; i++)
                {
                    float temp = Vector3.Distance(transform.position, Zombies[i].transform.position);
                    if(temp < furthest)
                    {
                        furthest = temp;
                        target = i;
                    }
                }
                Quaternion rotationNeeded = Quaternion.LookRotation(Zombies[target].transform.position - transform.position);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotationNeeded, Time.deltaTime * rotationSpeed);
                //transform.LookAt(Zombies[target].transform.position);
                ShootRay();
                muzzelFlash.SetActive(true);
                GameObject Shot = Instantiate(PistolShot, transform.position, transform.rotation);
                Destroy(Shot, 1f);
                autoRifleTimer = 0f;
            }
        }
    }
    void ShootRay()
    {
        RaycastHit Hit;
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z), transform.forward, out Hit))
        {
            Debug.Log(Hit.transform.name);
            if (!Hit.transform.name.Equals("F") && !Hit.transform.name.Equals("RedWood 2") && !Hit.transform.name.Equals("Terrain"))
            {
                if (GameObject.Find(Hit.transform.name).gameObject.GetComponent<m_Zombie>() != null)
                {
                    GameObject.Find(Hit.transform.name).gameObject.GetComponent<m_Zombie>().zombie.healthDown(20f);
                    GameObject.Find(Hit.transform.name).gameObject.GetComponent<m_Zombie>().zombie.Hit = true;
                    if (!Hit.transform.name.Equals("Dummy"))
                    {
                        if (!IsOpening)
                        {
                            GameObject.Find(Hit.transform.name).gameObject.GetComponent<MoveTowardsPlayer>().staggerTimer = 0;//<-- outside script control
                        }
                        if (IsOpening)
                        {
                            GameObject.Find(Hit.transform.name).gameObject.GetComponent<MoveTowardsPlayerOpening>().staggerTimer = 0;//<-- outside script control
                        }
                    }
                    Vector3 hitPoint = new Vector3(Hit.point.x, Hit.point.y, Hit.point.z);
                    GameObject bloodEffect = Instantiate(bloodHit, hitPoint, Quaternion.LookRotation(Hit.normal));
                    Destroy(bloodEffect, 1f);

                    autoRifleTimerMax = Random.Range(.1f, .4f);
                    autoRifleTimer = Random.Range(0, autoRifleTimerMax);
                }
            }
        }
    }
}
