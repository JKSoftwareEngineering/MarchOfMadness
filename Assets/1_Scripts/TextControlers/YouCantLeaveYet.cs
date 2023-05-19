using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouCantLeaveYet : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool youCanLeave = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(youCanLeave && other.gameObject.tag == "Player")
        {
            m_Map1.map1Safe = false;
            SceneManager.LoadScene(4);
        }
    }
}
