using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment16
{
    public struct Position
{
    public float X,Y,Z;


    public Position(float x, float y, float z){
        X=x;
        Y=y;
        Z=z;
    }

    public void printPosition(){
        Debug.Log("The position is : X= (" + X + "), Y = (" + Y + "), Z = (" + Z + ") ");
    }
   
   
}

    
}
