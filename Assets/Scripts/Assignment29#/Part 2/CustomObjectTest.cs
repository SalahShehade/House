
using UnityEngine;

namespace Assignment29
{
    public class CustomObjectTest : MonoBehaviour
    {
        void Start()
        {


            CustomObject obj1 = new CustomObject(1, "PC1");
            print(obj1);

            CustomObject obj2 = new CustomObject(1, "PC1");

            print("obj1 == obj2: " + (obj1 == obj2));

            print("obj1 != obj2: " + (obj1 != obj2));

        }
    }
}
