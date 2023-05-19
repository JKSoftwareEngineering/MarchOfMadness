using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerObject;

public class MovementControl : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController cont;
    private float x;
    private float z;
    //[HideInInspector] public bool moving = false;
    private float speed = 2f;
    void Start()
    {
        cont = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
                m_Initialize.player.Running = !m_Initialize.player.Running;
        }
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        if(x!=0||z!=0)
        {
            m_Initialize.player.moving = true;
        }
        else
        {
            m_Initialize.player.moving = false;
        }
        Vector3 move = transform.right * x + transform.forward * z;
        cont.Move(move * m_Initialize.player.getSpeed() * Time.deltaTime);
        // there is no jumping so easy answer is just snap the object to the ground instead of using gravity.
        Vector3 grounding = new Vector3(transform.position.x, 0, transform.position.z);
        transform.position = grounding;
    }
}
