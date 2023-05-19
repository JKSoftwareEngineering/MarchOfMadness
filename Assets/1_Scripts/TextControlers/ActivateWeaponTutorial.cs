using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateWeaponTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject WeaponTutorialText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            WeaponTutorialText.SetActive(true);
            Destroy(gameObject);
        }
    }
}
