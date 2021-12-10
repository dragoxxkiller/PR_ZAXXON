using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaMov : MonoBehaviour
{


    float speed;

    // Start is called before the first frame update
    void Start()
    {
        print(gameObject.name);

        if(gameObject.name == "Muros")
        {
            speed = 4f;
        }
        else if(gameObject.name == "Palme_Dia_grand")
        {
            speed = 3f;
        }
        else if (gameObject.name == "Plataforma")
        {
            speed = 18f;
        }
       /* else if (gameObject.name == "Palme_grand")
        {
            speed = 6f;
        }
        else if (gameObject.name == "Palme_grand")
        {
            speed = 3f;
        }*/
        else
        {
            speed = 6f;
        }

        


    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.left * Time.deltaTime * speed);


    }



}
