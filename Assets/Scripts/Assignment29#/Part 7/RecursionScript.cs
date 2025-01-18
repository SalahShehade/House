using UnityEngine;

namespace Assignment29
{
    public class RecursionScript : MonoBehaviour
    {
        void Start()
        {
            int n1 = 10;
            int n2 = 30;

            int fibRecursion_n1 = FibonacciRecursive(n1);
            Debug.Log($"Fibonacci Recursive for n = {n1}: {fibRecursion_n1}");

            int fibIterative_n1 = FibonacciIterative(n1);
            Debug.Log($"Fibonacci Iterative for n = {n1}: {fibIterative_n1}");

            int fibRecursion_n2 = FibonacciRecursive(n2);
            Debug.Log($"Fibonacci Recursive for n = {n2}: {fibRecursion_n2}");

            int fibIterative_n2 = FibonacciIterative(n2);
            Debug.Log($"Fibonacci Iterative for n = {n2}: {fibIterative_n2}");
        }

        int FibonacciRecursive(int n)
        {
            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        int FibonacciIterative(int n)
        {
            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;

            int a = 0, b = 1, temp;
            for (int i = 2; i <= n; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }
    }
}
