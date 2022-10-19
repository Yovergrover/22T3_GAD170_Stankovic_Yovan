using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;

namespace YovanStankovic
{
    public enum themans { Undefined, Gru, Minions, Gerald }
    public class WeekFiveActivity : MonoBehaviour
    {
        [SerializeField] private themans chosenpoopoo = themans.Undefined;
        [SerializeField] private string firstName;
        [SerializeField] private string lastName;
        [SerializeField] private string preferredName;
        [SerializeField] private string phoneNumber;
        [SerializeField] private string address;
        [SerializeField] private string email;

        public void Initialise()
        {
            Setup("Gru", "voluptuous", "Tony Soprano", "(02) 9212 5457", "308 Negra Arroyo Lane, Albuquerque, New Mexico. 87104", "ermderm@gmail.com");

            switch (chosenpoopoo)
            {
                case themans.Undefined:
                    Debug.Log("uh uh uh, no no no, set the enum you bigdumb");
                    break;
                case themans.Gru:
                    Setup("Gru", "voluptuous", "Tony Soprano", "(02) 9212 5457", "308 Negra Arroyo Lane, Albuquerque, New Mexico. 87104", "ermderm@gmail.com");
                    break;
                case themans.Minions:
                    Setup("Minions", "1987", "as a burger", "(02) 9212 5457", "Big Mama's House", "teehee.com@gmail");
                    break;
                case themans.Gerald:
                    Setup("Gerald", "Robotsnooks", "Snookster", "(02) 9212 5457", "The White House", "ermderm@gmail.com");
                    break;
                default:
                    Debug.Log("Erm... wrong");
                    break;


            }
            //SetupGerald();
            //SetupGru();
            //SetupMinions();
        }

        private void Setup(string newFirstName,
                           string newLastName,
                           string newPreferredName,
                           string newPhoneNumber,
                           string newAddress,
                           string newEmail)
        {
            firstName = newFirstName;
            lastName = newLastName; 
            preferredName = newPreferredName;
            phoneNumber = newPhoneNumber;
            address = newAddress;
            email = newEmail;
        }

        private void SetupGru()
        {
            firstName = "Gru";
            lastName = "voluptuous";
            preferredName = "Tony Soprano";
            phoneNumber = "(02) 9212 5457";
            address = "308 Negra Arroyo Lane, Albuquerque, New Mexico. 87104";
            email = "ermderm@gmail.com";
        }
        private void SetupMinions()
        {
            firstName = "Minions";
            lastName = "1987";
            preferredName = "as a burger";
            phoneNumber = "(02) 9212 5457";
            address = "Big Mama's House";
            email = "teehee.com@gmail";
        }

        private void SetupGerald()
        {
            firstName = "Gerald";
            lastName = "Robotsnooks";
            preferredName = "Snookster";
            phoneNumber = "(02) 9212 5457";
            address = "The White House";
            email = "ermderm@gmail.com";
        }
    }
}