using UnityEngine;

namespace Assignment29
{
    public class UnitySpecificScript : MonoBehaviour
    {
        private GameObject targetObject;

        void OnEnable()
        {
            print("GameObject Enabled");
        }

        void OnDisable()
        {
            print("GameObject Disabled");
        }

        void Start()
        {
            print("Game started!");

            targetObject = GameObject.Find("TargetObject");
            if (targetObject != null)
            {
                print("Found object by name: " + targetObject.name);
            }
            else
            {
                print("No TargetObject found.");
            }

            GameObject joker = GameObject.FindGameObjectWithTag("Joker");
            if (joker != null)
            {
                print("Found object by tag: " + joker.name);
            }
            else
            {
                print("No Joker object found.");
            }

            Light lightObj = GameObject.FindObjectOfType<Light>();
            if (lightObj != null)
            {
                print("Found object of type Light: " + lightObj.name);
            }
            else
            {
                print("No Light object found.");
            }
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (targetObject != null && targetObject.activeSelf)
                {
                    targetObject.SetActive(false);
                    print("TargetObject deactivated!");
                }
            }
        }
    }
}
