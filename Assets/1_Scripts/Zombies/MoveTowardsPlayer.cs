using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject player;
    private CharacterController cont;
    private m_Zombie thisZombie;
    private Animator anim;
    private bool Attack = false;
    private int RandomAttackAnimation = 0;
    private bool Attack1 = false;
    private bool Attack2 = false;
    private bool Attack3 = false;
    private bool Hit = false;
    private bool HitTimer = false;
    private bool Move = false;
    public float staggerTimer = 0f;
    private float staggerTimerMax = 2f;
    public float attackTimer = 0f;
    private float attackTimerMax = 1.2f;
    void Start()
    {
        thisZombie = GetComponent<m_Zombie>();
        cont = GetComponent<CharacterController>();
        thisZombie.zombie.setSpeed(Random.Range(.75f, .9f));
        anim = GetComponent<Animator>();
        anim.SetFloat("move", Random.Range(0.0f, 1.0f));//this is the offset for the animation, it is set to reset if the value is above 2 which should never happen
    }

    // Update is called once per frame
    void Update()
    {
        if (thisZombie.zombie.isAlive())
        {
            player = GameObject.Find("Player");
            transform.LookAt(player.transform);
            #region Stagger if hit
            //2f is a magic number based on the animtion run time if animaton is changed delay needs to be changed
            if (thisZombie.zombie.Hit)
            {
                HitTimer = true;
            }
            if(HitTimer)
            {
                staggerTimer += Time.deltaTime;
            }
            if (staggerTimer >= staggerTimerMax)
            {
                HitTimer = false;
                staggerTimer = 0f;
            }
            #endregion
            if (!HitTimer)
            {
                if (Vector3.Distance(player.transform.position, transform.position) < 20f)
                {
                    cont.Move(transform.forward * thisZombie.zombie.getSpeed() * Time.deltaTime);
                }
            }
        }
        Vector3 grounding = new Vector3(transform.position.x, 0, transform.position.z);
        transform.position = grounding;
        //Might be about the point to need a seperate animation script
        //                \/      \/      \/      \/
        Hit = thisZombie.zombie.Hit;
        if(Vector3.Distance(player.transform.position, transform.position) < 1.5f)
        {
            if (!Attack)
            {
                if (RandomAttackAnimation == 0)
                {
                    anim.SetTrigger("Attack1");
                    attackTimer = 0f;
                    Attack = true;
                }
                if (RandomAttackAnimation == 1)
                {
                    anim.SetTrigger("Attack2");
                    attackTimer = 0f;
                    Attack = true;
                }
                if (RandomAttackAnimation == 2)
                {
                    anim.SetTrigger("Attack3");
                    attackTimer = 0f;
                    Attack = true;
                }
            }
        }
        if(Attack)
        {
            attackTimer += Time.deltaTime;
        }
        if(attackTimer >= attackTimerMax)
        {
            RandomAttackAnimation = (int)Random.Range(0,4);
            Attack = false;
        }
        if (Hit)
        {
            ResetStates();
            anim.SetTrigger("Hit");
            thisZombie.zombie.Hit = false;
        }
    }
    public void ResetStates()
    {
        Attack1 = false;
        Attack2 = false;
        Attack3 = false;
        Hit = false;
        Move = false;
    }
}
