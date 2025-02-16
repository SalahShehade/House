using UnityEngine;
namespace Assignment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        void Start()
        {
            int health = 100;
            object boxedHealth = health;
            int unboxedHealth = (int)boxedHealth;
            unboxedHealth += 50;

            Debug.Log("Original Health: " + health);
            Debug.Log("Boxed Health: " + boxedHealth);
            Debug.Log("Unboxed and Modified Health: " + unboxedHealth);
        }
    }
}