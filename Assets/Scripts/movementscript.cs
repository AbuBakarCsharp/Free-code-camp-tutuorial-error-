using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementscript : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 1000;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 pos = transform.position;
        pos.x += h * Time.deltaTime * speed;
        pos.y += v * Time.deltaTime * speed;

        transform.position = pos;
    }
}
