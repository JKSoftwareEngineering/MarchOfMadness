using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSceneWeaponsTutorial : MonoBehaviour
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
        if (gameObject.activeInHierarchy)
        {
            move.enabled = false;
            turn.enabled = false;
            shoot.enabled = false;
        }
    }
    public void updateText()
    {
        move.enabled = true;
        turn.enabled = true;
        shoot.enabled = true;
        Destroy(gameObject);
    }
}
