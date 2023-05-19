using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaControl : MonoBehaviour
{
    // Start is called before the first frame update
    private MovementControl move;
    void Start()
    {
        move = GetComponent<MovementControl>();
    }

    // Update is called once per frame
    void Update()
    {

        if (m_Initialize.player.Running)
        {
            if (m_Initialize.player.moving)
            {
                m_Initialize.player.staminaDown(.2f);
            }
        }
        if(m_Initialize.player.getStamina() <= 0)
        {
            m_Initialize.player.Running = false;
        }
        if (m_Initialize.player.getHunger() > 0)
        {
            m_Initialize.player.staminaUp(.1f);
        }
    }
}
