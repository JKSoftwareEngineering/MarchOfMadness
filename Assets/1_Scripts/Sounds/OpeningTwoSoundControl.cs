using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningTwoSoundControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject one;
    [SerializeField] private GameObject two;
    private float soundTimmer = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        soundTimmer += Time.deltaTime;
        if (soundTimmer > 0 && soundTimmer < 61f)
        {
            one.SetActive(true);
        }
        if (soundTimmer > 61f)
        {
            one.SetActive(false);
            two.SetActive(true);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene(3);
        }
        if (soundTimmer > 61f + 28f + 3f)
        {
            SceneManager.LoadScene(3);
        }
    }
}
