using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateExitControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject ExitTutorialText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        ExitTutorialText.SetActive(true);
    }
}
