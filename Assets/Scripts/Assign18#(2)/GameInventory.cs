using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18_2
{

    public class GameInventory : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Inventory potions = new Inventory();
            potions.AddItem("Healing Potion");
            potions.AddItem("Strength Potion");

            Inventory elixers = new Inventory();
            elixers.AddItem("Elixirs");
            elixers.AddItem("Dark Elixirs");

            Inventory fullInventory = potions + elixers;
            fullInventory.ShowItems();


        }

        // Update is called once per frame

    }

}
