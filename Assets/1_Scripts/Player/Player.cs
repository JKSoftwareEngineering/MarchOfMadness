using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PlayerObject
{
    public class Player
    {
        private float Health;
        private float HealthMax = 100f;
        private float Stamina;
        private float StaminaMax = 100f;
        private float Hunger;
        private float HungerMax = 100f;
        public int WeaponSelected;//0 is secondary, 1 is primary
        private int FoodCount;
        private int PrimaryAmmo;
        private int SecondaryAmmo;
        private int MissionStatus; //-1 is testmap
        public bool Running = false;
        public bool moving = false;
        public bool FireLongArm = false;
        public bool FireSmallArm = false;

        public Player()
        {
            Health = HealthMax;
            Stamina = StaminaMax;
            Hunger = HungerMax;
            Running = false;
            FoodCount = 0;
            WeaponSelected = 0;
            PrimaryAmmo = 150;
            SecondaryAmmo = 50;
            MissionStatus = 0;
        }
        public void loadPlayer(float health, float stamina, float hunger, int foodCount, int weaponSelected, int primaryAmmo, int secondaryAmmo, int missionStatus)
        {
            Health = health;
            Stamina = stamina;
            Hunger = hunger;
            Running = false;
            FoodCount = foodCount;
            WeaponSelected = weaponSelected;
            PrimaryAmmo = primaryAmmo;
            SecondaryAmmo = secondaryAmmo;
            MissionStatus = missionStatus;
        }
        public float getHealth()
        {
            return Health;
        }
        public float getHealthMax()
        {
            return HealthMax;
        }
        public void healthDown(float f)
        {
            Health -= f;
        }
        public float getStamina()
        {
            return Stamina;
        }
        public float getStaminaMax()
        {
            return StaminaMax;
        }
        public void staminaDown(float f)
        {
            Stamina -= f;
        }
        public void staminaUp(float f)
        {
            Stamina += f;
            if(Stamina > StaminaMax)
            {
                Stamina = StaminaMax;
            }
        }
        public float getHunger()
        {
            return Hunger;
        }
        public float getHungerMax()
        {
            return HungerMax;
        }
        public void hungerDown(float f)
        {
            Hunger -= f;
        }
        public float getSpeed()
        {
            if (Running)
            {
                return 5f;
            }
            else
            {
                return 2f;
            }
        }
        public int getFoodCount()
        {
            return FoodCount;
        }
        public void pickUpFood()
        {
            FoodCount++;
        }
        public void useFood()
        {
            FoodCount--;
            Hunger += 50;
            if(Hunger > 100f)
            {
                Hunger = 100f;
            }
        }
        public int getWeaponAmmo()
        {
            if(WeaponSelected == 1)
            {
                return SecondaryAmmo;
            }
            else if(WeaponSelected == 2)
            {
                return PrimaryAmmo;
            }
            else
            {
                return 0;
            }
        }
        public bool fireRound()
        {
            if(WeaponSelected == 1)
            {
                if(SecondaryAmmo > 0)
                {
                    SecondaryAmmo--;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if(WeaponSelected == 2)
            {
                if(PrimaryAmmo > 0)
                {
                    PrimaryAmmo--;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            Debug.Log("Weapon Missing");
            return false;
        }
        public void SwitchWeapon()// not using else since there might be more weapons carried added later
        {
            if(WeaponSelected == 0)
            {
                WeaponSelected = 1;
                return;
            }
            if(WeaponSelected == 1)
            {
                WeaponSelected = 2;
                return;
            }
            if (WeaponSelected == 2)
            {
                WeaponSelected = 1;
                return;
            }
        }

        // only for save and load
        public int getPrimaryAmmo()
        {
            return PrimaryAmmo;
        }
        // only for save and load
        public int getSecondaryAmmo()
        {
            return SecondaryAmmo;
        }

        public int getMissionStatus()
        {
            return MissionStatus;
        }
        public void NextMission()
        {
            MissionStatus++;
        }
    }
}
