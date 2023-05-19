using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraightForTitle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject player;
    private CharacterController cont;
    private m_Zombie thisZombie;
    private Animator anim;
    void Start()
    {
        thisZombie = GetComponent<m_Zombie>();
        cont = GetComponent<CharacterController>();
        thisZombie.zombie.setSpeed(Random.Range(.75f, .9f));
        anim = GetComponent<Animator>();
        anim.SetFloat("move", Random.Range(0.0f, 1.0f));//this is the offset for the animation, it is set to reset if the value is above 2 which should never happen
        transform.LookAt(player.transform);
    }

    // Update is called once per frame
    void Update()
    {
        cont.Move(transform.forward * thisZombie.zombie.getSpeed() * Time.deltaTime);
        Vector3 grounding = new Vector3(transform.position.x, 0, transform.position.z);
        transform.position = grounding;
    }
}
