using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        m_Initialize.player.hungerDown(.002f);
    }
}
