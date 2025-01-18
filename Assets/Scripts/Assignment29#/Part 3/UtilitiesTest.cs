using UnityEngine;

namespace Assignment29
{
    public class UtilitiesTest : MonoBehaviour
    {
        void Start()
        {
            int sum = Utilities.Add(1, 2, 3, 4, 5, 10);
            Debug.Log("Sum: " + sum);

            string repeatedString = "Hello".RepeatString(3);
            Debug.Log("Repeated String: " + repeatedString);
        }
    }
}
