using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment18_2
{
    public class Inventory
    {
        private List<string> itemsList = new List<string>();

        public void AddItem(string item)
        {
            itemsList.Add(item);
        }

        public void ShowItems()
        {
            foreach (string item in itemsList)
            {
                Debug.Log(item);
            }
        }


        public static Inventory operator +(Inventory a, Inventory b)
        {
            Inventory combined = new Inventory();
            combined.itemsList.AddRange(a.itemsList);
            combined.itemsList.AddRange(b.itemsList);


            return combined;

        }



    }


}
