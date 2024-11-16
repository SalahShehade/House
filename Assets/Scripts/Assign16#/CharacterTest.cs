using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment16 {


public class CharacterTest : MonoBehaviour
{
    Soldier soldier;
    Officer officer;

    Character[] characters = new Character[2];

    void Start()
    {
        
         soldier = new Soldier();
         officer = new Officer("Colonel", 80 , new Position(3,6,9));

        characters [0] = soldier;
        characters [1] = officer;

        for(int i = 0; i < characters.Length ; i++){
            characters[i].DisplayInfo();
        }

         Debug.Log("Before attack: ");
            soldier.DisplayInfo();

        officer.Attack(35,soldier);


         Debug.Log("After attack:");
            soldier.DisplayInfo();
    }

    
}
}