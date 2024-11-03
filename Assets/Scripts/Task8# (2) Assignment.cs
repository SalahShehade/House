using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] funnyarr = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"} ;
        int i = 0 ;

        int Randomnum;
        string finalSentence = "";

          
          while (i <  7){

            Randomnum = Random.Range(0,10);
            finalSentence += funnyarr[Randomnum] + " ";



            i++;
          }
          Debug.Log("The funny sentence is : " + finalSentence);
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
