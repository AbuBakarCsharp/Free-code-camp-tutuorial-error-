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
        StartCoroutine("blah");
        StopCoroutine("blah");

        lol();
        LOL(5, 3);

        //Class
        Player hero = new Player(100,100,Steve);
        Player hero = new Player(100,100,Steve);
    }

    IEnumerator blah()
    {
        yield return new WaitForSeconds(9f);

        print("HAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHA");
        yield return new WaitForSeconds(7f);

        print("HEHEHEH");
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
