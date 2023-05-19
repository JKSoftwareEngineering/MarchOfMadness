using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntroSceneTextControl : MonoBehaviour
{
    // Start is called before the first frame update
    private int Text = 0;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private MovementControl move;
    [SerializeField] private TurnToMouse turn;
    [SerializeField] private WeaponControl shoot;

    void Start()
    {
        move.enabled = false;
        turn.enabled = false;
        shoot.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Text == 0)
        {
            text.text = "Brian Andrews reporting for duty.";
        }
        if (Text == 1)
        {
            text.text = "At ease, we're sending you on a quick snatch and grab in Ohio.\n\nYou are to rendezvous with corporal Marven Stillman and his team at the airport he should be able to give you a better idea of the conditions on the ground.";
        }
        if (Text == 2)
        {
            text.text = "Do we know what I'm picking up?";
        }
        if (Text == 3)
        {
            text.text = "An external hard drive, as long as everything goes according to \n" +
                "plan they should meet you at the door with it.";
        }
        if (Text == 4)
        {
            text.text = "Got it.";
        }
        if (Text == 5)
        {
            text.text = "Your flight leaves in two hours, grab something to eat and \n" +
                "check out your equipment, a driver will be waiting in the lobby in \n" +
                "about an hour.  Dismissed.";
        }
        if (Text == 6)
        {
            move.enabled = true;
            turn.enabled = true;
            shoot.enabled = true;
            Destroy(gameObject);
        }
    }
    public void updateText()
    {
        Text++;
    }
}
