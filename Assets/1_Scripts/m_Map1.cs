using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m_Map1 : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool map1Safe = true;
    private bool MissionUpdated = false;
    [SerializeField] private GameObject AIPointControl;
    [SerializeField] private GameObject ZombieContainer;
    [SerializeField] private GameObject MissionUpdate5;
    [SerializeField] private GameObject MissionUpdate1;
    [SerializeField] private GameObject zombieSpawner;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject playerSafeStart;
    [SerializeField] private GameObject playerUnSafeStart;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(map1Safe)
        {
            AIPointControl.SetActive(true);
            if (!MissionUpdated)
            {
                MissionUpdate1.SetActive(true);
                player.transform.position = playerSafeStart.transform.position;
                MissionUpdated = true;
            }
            MissionUpdate5.SetActive(false);
            ZombieContainer.SetActive(false);
        }
        else
        {
            AIPointControl.SetActive(false);
            MissionUpdate1.SetActive(false);
            if (!MissionUpdated)
            {
                MissionUpdate5.SetActive(true);
                player.transform.position = playerUnSafeStart.transform.position;
                Instantiate(zombieSpawner, transform.position, Quaternion.identity);
                MissionUpdated = true;
            }
            ZombieContainer.SetActive(true);
        }
    }
}
