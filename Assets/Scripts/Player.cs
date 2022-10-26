using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    int health;
    string name;
    int power;

    //This is getter and setter together
    public int Health
    {
        
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }
    
    public Player (int health,int power,string name)
    {
        this.health = health;
        this.power = power;
        this.name = name;
    }

    //setter
    public void SetHealth (int health)
    {
        this.health = health;
    }

    //getter
    public int GetHealth()
    {
        return this.health;
    }
    public void Info()
    {
        Debug.Log($"Health is {health}");
        Debug.Log($"Name is {name}");
        Debug.Log($"Power is {power}");
    }
    public void Attack()
    {
        Debug.Log($"{name} is attacking");
    }
    public void Healing()
    {
        Debug.Log($"{name} is healing and health is increasing");
    }
}
