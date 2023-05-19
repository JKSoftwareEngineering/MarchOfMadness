using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIConnections : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Slider healthSlider;
    [SerializeField] private Slider hungerSlider;
    [SerializeField] private Slider staminaSlider;
    [SerializeField] private TextMeshProUGUI foodVal;
    [SerializeField] private TextMeshProUGUI ammoVal;
    [SerializeField] private GameObject secondary;
    [SerializeField] private GameObject primary;
    public Texture2D cursor;
    void Start()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
        healthSlider.value = m_Initialize.player.getHealthMax();
        hungerSlider.value = m_Initialize.player.getHungerMax();
        staminaSlider.value = m_Initialize.player.getStaminaMax();
        foodVal.text = "" + m_Initialize.player.getFoodCount();
        ammoVal.text = "" + m_Initialize.player.getWeaponAmmo();
        secondary.SetActive(false);
        primary.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        healthSlider.value = m_Initialize.player.getHealth();
        hungerSlider.value = m_Initialize.player.getHunger();
        staminaSlider.value = m_Initialize.player.getStamina();
        foodVal.text = "" + m_Initialize.player.getFoodCount();
        ammoVal.text = "" + m_Initialize.player.getWeaponAmmo();
        if (m_Initialize.player.WeaponSelected == 0)
        {
            secondary.SetActive(false);
            primary.SetActive(false);
        }
        if (m_Initialize.player.WeaponSelected == 1)
        {
            secondary.SetActive(true);
            primary.SetActive(false);
        }
        if (m_Initialize.player.WeaponSelected == 2)
        {
            secondary.SetActive(false);
            primary.SetActive(true);
        }
    }
}
