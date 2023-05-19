using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ZombieObject
{
    public class Zombie
    {
        private float Health;
        private float Speed;
        private float Damage;
        private bool Alive;
        public bool Hit = false;
        public int zedType = 0; // 0 male, 1 female
        
        public Zombie()
        {
            Health = 100;
            Speed = 0;
            Damage = 4;
            Alive = true;
        }
        public void healthDown(float f)
        {
            Health -= f;
            Hit = true;
            if(Health <= 0)
            {
                Alive = false;
            }
        }
        public float getDamage()
        {
            return Damage;
        }
        public float getSpeed()
        {
            return Speed;
        }
        public void setSpeed(float f)
        {
            Speed = f;
        }
        public bool isAlive()
        {
            return Alive;
        }
    }
}
