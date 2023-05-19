using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationControl : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    private float x;
    private float z;
    #region Bool States
    private bool Idleing = true;
    private bool IdleingPistol = false;
    private bool IdleingRifle = false;
    private bool Walking = false;
    private bool WalkingPistol = false;
    private bool WalkingRifle = false;
    private bool Running = false;
    private bool RunningPistol = false;
    private bool RunningRifle = false;
    private bool RifleFireIdle = false;
    #endregion
    void Start()
    {
        anim = GetComponent<Animator>();
        //weapon = GetComponent<WeaponControl>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        if (m_Initialize.player.WeaponSelected == 0)
        { 
            if (!m_Initialize.player.Running)
            {
                if (!Walking)
                {
                    if (x != 0 || z != 0)
                    {
                        anim.SetTrigger("Walking");
                        ResetStates();
                        Walking = true;
                    }
                }
            }
            if (m_Initialize.player.Running)
            {
                if (!Running)
                {
                    if (x != 0 || z != 0)
                    {
                        anim.SetTrigger("Running");
                        ResetStates();
                        Running = true;
                    }
                }
            }
            if (!Idleing)
            {
                if (x == 0 && z == 0)
                {
                    anim.SetTrigger("Idle");
                    ResetStates();
                    Idleing = true;
                }
            }
        }
        if (m_Initialize.player.WeaponSelected == 1)
        {
            if (!m_Initialize.player.Running)
            {
                if (!WalkingPistol)
                {
                    if (x != 0 || z != 0)
                    {
                        anim.SetTrigger("PistolWalk");
                        ResetStates();
                        WalkingPistol = true;
                    }
                }
            }
            if (m_Initialize.player.Running)
            {
                if (!RunningPistol)
                {
                    if (x != 0 || z != 0)
                    {
                        anim.SetTrigger("PistolRun");
                        ResetStates();
                        RunningPistol = true;
                    }
                }
            }
            if (!IdleingPistol)
            {
                if (x == 0 && z == 0)
                {
                    anim.SetTrigger("PistolIdle");
                    ResetStates();
                    IdleingPistol = true;
                }
            }
        }
        if (m_Initialize.player.WeaponSelected == 2)
        {
            if (!m_Initialize.player.Running)
            {
                if (!WalkingRifle)
                {
                    if (x != 0 || z != 0)
                    {
                        anim.SetTrigger("RifleWalk");
                        ResetStates();
                        WalkingRifle = true;
                    }
                }
            }
            if (m_Initialize.player.Running)
            {
                if (!RunningRifle)
                {
                    if (x != 0 || z != 0)
                    {
                        anim.SetTrigger("RifleRun");
                        ResetStates();
                        RunningRifle = true;
                    }
                }
            }
            //if (!RifleFireIdle && m_Initialize.player.FireLongArm)
            //{
            //    if (x == 0 && z == 0)
            //    {
            //        anim.SetTrigger("RifleFireIdle");  // animation is not lining up and i am spending way to much time and getting really annoyed with it, also need a waliking fire rifle animation
            //        ResetStates();
            //        RifleFireIdle = true;
            //        //m_Initialize.player.FireLongArm = false;
            //    }
            //}
            if (!IdleingRifle)
            {
                if (x == 0 && z == 0)
                {
                    anim.SetTrigger("RifleIdle");
                    ResetStates();
                    IdleingRifle = true;
                }
            }
        }
    }
    public void ResetStates()
    {
        Idleing = false;
        IdleingPistol = false;
        IdleingRifle = false;
        Walking = false;
        WalkingPistol = false;
        WalkingRifle = false;
        Running = false;
        RunningPistol = false;
        RunningRifle = false;
        RifleFireIdle = false;
    }
}
