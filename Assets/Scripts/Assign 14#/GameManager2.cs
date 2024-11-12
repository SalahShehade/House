using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player2 p1 = new Player2("abdul", 40);
        Enemy e1 = new Enemy("Aydi", 70);

        Debug.Log("Player: " + p1.Name + " has " + p1.Health + " HP");
        Debug.Log("Enemy: " + e1.Name + " has " + e1.Health + " HP");

        p1.Heal(50);

        e1.Attack(p1, 30);


        Debug.Log("After attack " + p1.Name + " has " + p1.Health + " HP");
        Debug.Log("After attack " + e1.Name + "' has " + e1.Health + "HP");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
