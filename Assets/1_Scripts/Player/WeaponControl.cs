using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeaponControl : MonoBehaviour
{
    [SerializeField] private Light MuzzelFlash;
    [SerializeField] private GameObject bloodHit;
    [SerializeField] private GameObject GunShotSound;
    private float autoRifleTimer = 0f;
    private float autoRifleTimerMax = 0.15f;
    private float pistolDelayTimer = 0;
    private float pistolDelayTimerMax = .5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        autoRifleTimer += Time.deltaTime;
        pistolDelayTimer += Time.deltaTime;
        MuzzelFlash.gameObject.SetActive(false);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            m_Initialize.player.SwitchWeapon();
        }
        if (m_Initialize.player.WeaponSelected == 1) // small arm idle fire, is in the player class but since the idle and fire animation are the same it dosnt need to be set at this time
        {
            if (pistolDelayTimer >= pistolDelayTimerMax)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    if (m_Initialize.player.fireRound())
                    {
                        MuzzelFlash.gameObject.SetActive(true);
                        pistolDelayTimer = 0f;
                        ShootRay();
                    }
                }
            }
        }
        if (m_Initialize.player.WeaponSelected == 2)
        {
            if (autoRifleTimer >= autoRifleTimerMax)
            {
                if (Input.GetButton("Fire1"))
                {
                    m_Initialize.player.FireLongArm = true;
                    if (m_Initialize.player.fireRound())
                    {
                        MuzzelFlash.gameObject.SetActive(true);
                        ShootRay();
                        autoRifleTimer = 0f;
                    }
                }
            }
        }
    }
    void ShootRay()
    {
        GameObject Shot = Instantiate(GunShotSound, transform.position, transform.rotation);
        Destroy(Shot, 1f);
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
                        GameObject.Find(Hit.transform.name).gameObject.GetComponent<MoveTowardsPlayer>().staggerTimer = 0;//<-- outside script control
                    }
                    Vector3 hitPoint = new Vector3(Hit.point.x, Hit.point.y, Hit.point.z);
                    GameObject bloodEffect = Instantiate(bloodHit, hitPoint, Quaternion.LookRotation(Hit.normal));
                    Destroy(bloodEffect, 2f);
                }
            }
            //Destroy(GameObject.Find(Hit.transform.name));
        }
    }
}
