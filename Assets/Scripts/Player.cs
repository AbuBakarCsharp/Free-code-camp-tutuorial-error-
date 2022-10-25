using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    int health;
    string name;
    int power;

    public Player (int health,int power,string name)
    {
        this.health = health;
        this.power = power;
        this.name = name;
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
