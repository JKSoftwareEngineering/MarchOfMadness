using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(m_Initialize.player.getHunger() <= 0)
        {
            m_Initialize.player.healthDown(.05f);
        }
    }
}
