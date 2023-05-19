using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIntro : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Intro;
    private float speed = .45f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 step = new Vector3(Intro.transform.position.x, Intro.transform.position.y + speed, Intro.transform.position.z);
        Intro.transform.position = step;
    }
}
