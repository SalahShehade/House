using UnityEngine;
using System;

namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            var myInt = 5;
            var myString = "Unity";
            var myBool = true;

            string oddOrEven = (myInt % 2 == 0) ? "even" : "odd";

            Debug.Log($"The number {myInt} is {oddOrEven}.");

            Debug.Log($"Current Date: {DateTime.Now.ToShortDateString()}");
            Debug.Log($"Current Time: {DateTime.Now.ToLongTimeString()}");
            Debug.Log($"Current Day: {DateTime.Now.DayOfWeek}");
        }
    }
}
