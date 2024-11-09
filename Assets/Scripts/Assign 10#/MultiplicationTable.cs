using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
   
    void Start()
    {    
        int staticnum =5 ;
        for (int i = 1 ; i <=10; i++ ){

            int result = Multiply(i,staticnum);

            Debug.Log(staticnum + " x "+ i + " = "+ result );

            
        }
        
        
    }

    int Multiply (int num1 , int num2){
            return num1 * num2 ;
        }

   
    
}
