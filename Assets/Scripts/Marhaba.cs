using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marhaba : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int playerLives = 3;

        while(playerLives>0){

            if(playerLives==3){
                Debug.Log("Many Lives");
            }
            else if (playerLives ==1){
                Debug.Log("The last life!");
            }
            
            playerLives--;
        }
        Debug.Log("Game Over!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
