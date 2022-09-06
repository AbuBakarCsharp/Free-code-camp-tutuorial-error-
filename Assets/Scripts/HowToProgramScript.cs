using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToProgramScript : MonoBehaviour
{

    float speed = 5.5f;

    double hunger = 9.9;

    int health = 100;

    string name = "Steve";

    bool IsDead = true;

    private void Start()
    {
        print("This is from PRINT");
        Debug.Log("This is from DEBUG LOG");
    }

}
