using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionUpdate5 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private MovementControl move;
    [SerializeField] private TurnToMouse turn;
    [SerializeField] private WeaponControl shoot;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void updateText()
    {
        move.enabled = true;
        turn.enabled = true;
        shoot.enabled = true;
        Destroy(gameObject);
    }
}
