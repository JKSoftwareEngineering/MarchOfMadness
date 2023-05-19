using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionUpdate2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject cameraCenterCar;
    [SerializeField] private GameObject cameraCenterPlayer;
    [SerializeField] private GameObject zombieSpawner;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateText()
    {
        Player.SetActive(true);
        cameraCenterPlayer.SetActive(true);
        cameraCenterCar.SetActive(false);
        Instantiate(zombieSpawner, new Vector3(495, 0, 442), Quaternion.identity);
        Destroy(gameObject);
    }
}
