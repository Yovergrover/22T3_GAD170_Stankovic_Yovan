using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YovanStankovic
{
    /// <summary>
    /// This class holds all the logic for our levelling system, so that includes logic to handle levelling up, gaining XP and detecting when we should level up.
    /// </summary>
    public class LevellingSystem : MonoBehaviour
    {

        public int level;

        private float experience;

        private float experienceRequired;

        public float hp;

        private void Start()
        {
            // TODO XP 4/13: Set our current level to one.
            level = 1;
            hp = 100;
            experience = 0;
            experienceRequired = 100;

            // TODO XP Final: Add code comments describing what you hope your code is doing throughout this script.

            // TODO XP Bonus: Adjust our character's stats ("runSpeed" and/or "jumpStrength") based on their level. (Hint: You'll need a reference to the SimpleCharacterController script!)

        }

        private void Update()
        {
            Exp();

            if(Input.GetKeyDown(KeyCode.E))
            {
                experience += 100;
            }
        }

        void Levelup()
        {
            level += 1;
            experience = 0;

            switch (level)
            {
                case 2:
                    hp = 200;
                    experienceRequired = 200;
                    break;

                case 3:
                    hp = 300;
                    experienceRequired = 300;
                    print("Woah congrats, you reached level 3 :O");
                    break;
            }
        }

        void Exp()
        {
            if (experience >= experienceRequired)
                Levelup();
        }
    }
}
