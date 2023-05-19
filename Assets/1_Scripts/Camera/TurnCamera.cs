using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCamera : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject camCenter;
    [SerializeField] private GameObject camera;
    [SerializeField] private GameObject angledBase;
    [SerializeField] private GameObject centeredBase;
    private int cameraDirection = 0;
    private int cameraDirectionEnd = 0;
    private bool rotateLeft = false;
    private bool TopDown = false;
    private float FOV = 60;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FOV += Input.mouseScrollDelta.y * -1;
        if(FOV >= 80f)
        {
            FOV = 80f;
        }
        if(FOV <= 15f)
        {
            FOV = 15f;
        }
        camera.GetComponent<Camera>().fieldOfView = FOV;
        if (TopDown)
        {
            camera.transform.eulerAngles = centeredBase.transform.eulerAngles;
            camera.transform.position = centeredBase.transform.position;
        }
        else
        {
            camera.transform.eulerAngles = angledBase.transform.eulerAngles;
            camera.transform.position = angledBase.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            TopDown = !TopDown;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rotateLeft = true;
            cameraDirectionEnd = cameraDirection + 45;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            rotateLeft = false;
            cameraDirectionEnd = cameraDirection - 45;
        }
        if (rotateLeft)
        {
            if (cameraDirection < cameraDirectionEnd)
            {
                cameraDirection += 5;
            }
        }
        else
        {
            if (cameraDirection > cameraDirectionEnd)
            {
                cameraDirection -= 5;
            }
        }
        camCenter.transform.eulerAngles = new Vector3(0, cameraDirection, 0);
    }
}
