using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MissionUpdate1 : MonoBehaviour
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
        if (Text == 0)
        {
            text.text = "Brian Andrews reporting.";
        }
        if (Text == 1)
        {
            text.text = "Yea yea at ease.  \n\nIt seems that you are going to a research facility in Huron county to meet with Jessica Willard.  That's about 2 hours from here.  We haven't secured out that far yet.   Trees and powerlines are down all over the state and since there has been no contact for hours it's safe to assume that they are having the same problems as everyone else.  Theres a squad car at the edge of the tree line that you can use to get there, but be ready to hoof it if the roads are impassable.";
        }
        if (Text == 2)
        {
            text.text = "Got it.";
        }
        if (Text == 3)
        {
            text.text = "Dismissed \n\n[Just walk straight through the city]";
        }
        if (Text == 4)
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
