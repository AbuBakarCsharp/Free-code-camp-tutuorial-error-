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


    //main
    private void Start()
    {
        //int a = 6;
        //int b = 9;

        //StartCoroutine(blah());
        //StartCoroutine("blah");
        //StopCoroutine("blah");

        //lol();
        //LOL(5, 3);

        //Class
        //Player hero = new Player(100,100,"Steve");
        //hero.PleaseAttack();
        //hero.Healing();
        //hero.Info();
        //StartCoroutine(WaitForNextClass());

        //hero.SetHealth(70);
        //print($"Health is {hero.GetHealth()}");
        //hero.Health = 60;
        //print($"Health is {hero.Health}");

        Steeve Alex = new Steeve();
        Alex.SetName = Alex;
        Alex.SetHealth = 50;
        Alex.SetPower = 400;
        Alex.Info();
        //Alex.PleaseAttack();
    }

    IEnumerator WaitForNextClass() 
    {
        yield return new WaitForSeconds(4f);
        Player dragon = new Player(500,500,"Ender Dragon");
        dragon.Info();
        dragon.PleaseAttack();
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
