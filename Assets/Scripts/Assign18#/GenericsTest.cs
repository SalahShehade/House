using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{

    public class GenericsTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameContainer<string> specialItem = new GameContainer<string>();

            specialItem.SetItem("a Healing Potion");
            string item = specialItem.GetItem();

            Debug.Log("Stored item : " + item);

            string description = GameUtils.DescribeItem(item);
            Debug.Log(description);
        }

        // Update is called once per frame

    }

}
