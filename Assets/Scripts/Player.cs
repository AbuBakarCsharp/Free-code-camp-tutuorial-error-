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
    public string Name
    {
        get
            {
                return name;
            }
        set
        {
            name = value;
        }
    }
    public int Power
    {
        get
        {
            return power;
        }
        set
        {
            power = value;
        }
    }

    //Constructor
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
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetPower(int power)
    {
        this.power = power;
    }


    //getter
    public int GetHealth()
    {
        return this.health;
    }
    public string GiveName ()
    {
        return this.name;
    }
    public int GivePower ()
    {
        return this.power;
    }

    //info attack etc
    public void Info()
    {
        Debug.Log($"Health is {health}");
        Debug.Log($"Name is {name}");
        Debug.Log($"Power is {power}");
    }
    private void Attack()
    {
        Debug.Log($"{name} is attacking");
    }
    public void PleaseAttack()
    {
        Attack();
    }
    public void Healing()
    {
        Debug.Log($"{name} is healing and health is increasing");
    }

    //awein for inheritance
    public Player() { }
}
