using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboSStarT : MonoBehaviour
{

    float speed;
    [SerializeField] GameObject initObject;
    InitGame initGame;



    // Start is called before the first frame update
    void Start()
    {

        initObject = GameObject.Find("InitGame");
        initGame = initObject.GetComponent<InitGame>();





    }

    // Update is called once per frame
    void Update()
    {

        speed = initGame.spaceshipSpeed;

        // speed = 25f;
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        float posZ = transform.position.z;
        if (posZ < -20)
        {
            Destroy(gameObject);
        }



    }
}
