using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnToMouse : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Camera cam;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition); ;
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {

            Vector3 target = hit.point;
            target.y = 0;
            if (Vector3.Distance(target, transform.position) > 1f)
            {
                if (!hit.transform.name.Equals("F"))
                {
                    transform.LookAt(target);
                }
            }
        }
    }
}
