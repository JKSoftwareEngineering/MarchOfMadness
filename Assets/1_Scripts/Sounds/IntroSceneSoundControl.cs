using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSceneSoundControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioSource BackGroungMusic;
    [SerializeField] private AudioSource BackGroungMusic2;
    private bool sound = true;
    private float soundTimer = 0f;
    public float sound1Max = 16f;
    void Start()
    {
        BackGroungMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //  soundTimer += Time.deltaTime;
        //  if(soundTimer >= 8.1f && sound)
        //  {
        //      BackGroungMusic2.Play();
        //      BackGroungMusic.Stop();
        //      sound = false;
        //  }
        //  if (soundTimer >= 16.1f)
        //  {
        //      BackGroungMusic.Play();
        //      BackGroungMusic2.Stop();
        //      sound = true;
        //      soundTimer = 0;
        //  }
        //if (soundTimer >= sound1Max)
        //{
        //    BackGroungMusic.Play();
        //    soundTimer = 0f;
        //}
    }
}
