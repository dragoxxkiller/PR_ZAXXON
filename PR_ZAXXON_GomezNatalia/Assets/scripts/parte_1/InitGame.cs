using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitGame : MonoBehaviour
{

    public float spaceshipSpeed;
    public bool alive;

    // Start is called before the first frame update
    void Start()
    {


        spaceshipSpeed = 25f;


    }

    // Update is called once per frame
    void Update()
    {


        if (alive)
        {
            spaceshipSpeed += 0.001f;
        }

    }
}
