using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    protected string name;
    protected int health;


    public string Name
    {
        get { return name; }
        set { name = value; }
    }


    public int Health
    {
        get { return health; }
        set { health = Mathf.Clamp(value, 0, 100); }


    }

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

}
