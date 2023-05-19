using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntroSceneFoodTutorial : MonoBehaviour
{
    private int Text = 0;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private MovementControl move;
    [SerializeField] private TurnToMouse turn;
    [SerializeField] private WeaponControl shoot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeInHierarchy)
        {
            move.enabled = false;
            turn.enabled = false;
            shoot.enabled = false;
        }
        if (Text == 0)
        {
            text.text = "Hay Brian good to see ya. ";
        }
        if (Text == 1)
        {
            text.text = "Good to see you too Phil, do we still have those cookies.";
        }
        if (Text == 2)
        {
            text.text = "Na, once word got out they didnt survive the night.";
        }
        if (Text == 3)
        {
            text.text = "Damn..., alright let me get todays special";
        }
        if (Text == 4)
        {
            text.text = "You got it.";
        }
        if (Text == 5)
        {
            text.text = "There are some items in the world that can be collected and food items are one of them.  to collect the food item simply walk over it and it will be added to your stockpile\n\n[Use food Left Control]\n\nWarning if your hunger bar (blue) reaches zero your stamina (yellow) will not grow and your health (green) will drop.";
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
