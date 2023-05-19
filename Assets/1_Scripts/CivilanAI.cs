using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilanAI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject One;
    [SerializeField] private bool one = true;
    [SerializeField] private GameObject Two;
    [SerializeField] private bool two = true;
    [SerializeField] private GameObject Three;
    [SerializeField] private bool three = true;
    [SerializeField] private GameObject Four;
    [SerializeField] private bool four = true;
    private CharacterController cont;
    [SerializeField] private float speed = 2f;
    void Start()
    {
        cont = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(one)
        {
            transform.LookAt(One.transform);
            cont.Move(transform.forward * speed * Time.deltaTime);
            if(Vector3.Distance(transform.position, One.transform.position) < 1f)
            {
                one = false;
            }
        }
        else if (two)
        {
            transform.LookAt(Two.transform);
            cont.Move(transform.forward * speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, Two.transform.position) < 1f)
            {
                two = false;
            }
        }
        else if (three)
        {
            transform.LookAt(Three.transform);
            cont.Move(transform.forward * speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, Three.transform.position) < 1f)
            {
                three = false;
            }
        }
        else if (four)
        {
            transform.LookAt(Four.transform);
            cont.Move(transform.forward * speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, Four.transform.position) < 1f)
            {
                one = true;
                two = true;
                three = true;
            }
        }
    }
}
