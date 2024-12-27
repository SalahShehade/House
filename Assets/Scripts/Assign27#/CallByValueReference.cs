using UnityEngine;

namespace Assignment27
{
    public class CallByValueReference : MonoBehaviour
    {
        void Start()
        {
            int a = 5;
            int b = 10;
            int c;

            Debug.Log("Initial Values:");
            Debug.Log($"a = {a}");
            Debug.Log($"b = {b}");

            PassByValue(a);
            Debug.Log("\nAfter PassByValue(a):");
            Debug.Log($"a = {a}");


            PassByRef(ref b);
            Debug.Log("\nAfter PassByRef(ref b):");
            Debug.Log($"b = {b}");

            AssignUsingOut(out c);
            Debug.Log("\nAfter AssignUsingOut(out c):");
            Debug.Log($"c = {c}");
        }
        void PassByValue(int number)
        {
            number += 10;
        }

        void PassByRef(ref int number)
        {
            number += 10;
        }

        void AssignUsingOut(out int number)
        {
            number = 100;
        }
    }
}
