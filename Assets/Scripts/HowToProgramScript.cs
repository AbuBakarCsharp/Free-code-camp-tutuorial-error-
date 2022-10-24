using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToProgramScript : MonoBehaviour
{

    //float speed = 5.5f;

    //double hunger = 9.9;

    //int health = 100;

    //string name = "Steve";

    //bool IsDead = true;

    private void Start()
    {
        int a = 6;
        int b = 9;

        StartCoroutine(blah());

        lol();
        LOL(5, 3);
    }

    IEnumerator blah()
    {
        yield return new WaitForSeconds(9f);

        print("HAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHA");
    }

    static void lol()
    {
        print("This is from PRINT");
    }

    static int LOL(int a, int b)
    {
        return a + b;
    }


}
