using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningSoundControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject one;
    [SerializeField] private GameObject two;
    [SerializeField] private GameObject thr;
    private float soundTimmer = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        soundTimmer += Time.deltaTime;
        if (soundTimmer > 0 && soundTimmer < 38f)
        {
            one.SetActive(true);
        }
        if (soundTimmer > 38f && soundTimmer < (38f + 45f))
        {
            one.SetActive(false);
            two.SetActive(true);
        }
        if (soundTimmer > (38f + 45f))
        {
            two.SetActive(false);
            thr.SetActive(true);
        }
        if(Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene(2);
        }
        if(soundTimmer > 38f + 45f + 66f + 3f)// 3 because, temperay delay for text to finnish
        {
            SceneManager.LoadScene(2);
        }
    }
}
