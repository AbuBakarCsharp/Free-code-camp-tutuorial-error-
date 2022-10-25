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

        Debug.Log($"Health is {health}");
        Debug.Log($"Name is {name}");
        Debug.Log($"Power is {power}");
    }
}
