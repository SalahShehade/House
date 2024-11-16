using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment16
{
    public class Character
{
    public string name;
    private int health;
    protected Position position;

    public int Health  
    {
        get 
        {
            return health;
        }
        set
        {
            health = Mathf.Clamp(value,0,100);
        }
    }

    public Character(string name,int health,Position position)
    {
        this.name = name;
        this.health = health;
        this.position= position;
    }

    public Character() : this("No name", 100 , new Position(0,0,0)) {}


    public virtual void DisplayInfo() {
        Debug.Log("Name : " + name + "| Health : " + health );
        position.printPosition();
    }

    public void Attack (int damage , Character target) {
        target.health -= damage;
    }
    public void Attack(int damage , Character target, string attackType) {
        Attack(damage,target);
        Debug.Log("attack type is : "+ attackType);
    }
   
}

    
}
