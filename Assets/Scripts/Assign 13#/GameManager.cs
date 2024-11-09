using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player p1 = new Player();
        Player p2 = new Player();

        p1.InitializePlayer("abdul", 60);
        p2.InitializePlayer("fahad", 40);


        p1.Heal(true);
        p2.Heal(40);

        Player.ShowPlayerCount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
