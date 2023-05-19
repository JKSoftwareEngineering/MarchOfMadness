using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SqaudCarControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject StartPoint;
    [SerializeField] private GameObject EndPoint;
    [SerializeField] private GameObject CarModel;
    [SerializeField] private GameObject cameraCenterCar;
    [SerializeField] private GameObject cameraCenterPlayer;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Soldier1;
    [SerializeField] private GameObject Soldier2;
    private bool DrivingIn = false;
    private bool hasBeenActivated = false;
    private float speed = 12f;
    [SerializeField] private GameObject MissionUpdate2;
    private CharacterController cont;
    void Start()
    {
        cont = CarModel.GetComponent<CharacterController>();
        cameraCenterCar.SetActive(true);
        Soldier1.SetActive(false);
        Soldier2.SetActive(false);
        Player.SetActive(false);
        cameraCenterPlayer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(CarModel.transform.position, EndPoint.transform.position) > 2f)
        {
            CarModel.transform.LookAt(EndPoint.transform.position);
            cont.Move(transform.forward * speed * Time.deltaTime);
        }
        else
        {
            //cameraCenterCar.SetActive(false);
            //Soldier1.SetActive(true);
            //Soldier2.SetActive(true);
            if (!hasBeenActivated)
            {
                MissionUpdate2.SetActive(true);
                hasBeenActivated = true;
            }
            //Player.SetActive(true);
            //cameraCenterPlayer.SetActive(true);
        }
    }
}
