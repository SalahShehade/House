using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        int Randomnum ;
        while(i<20){
            Randomnum = Random.Range(1,21);
            
            if(Randomnum == 5){
                i++;
                continue;
            } 

            else if(Randomnum == 15) break;

            Debug.Log(Randomnum);
            i++;

        }
          
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
