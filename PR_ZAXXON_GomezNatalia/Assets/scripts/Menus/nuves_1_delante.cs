using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuves_1_delante : MonoBehaviour
{
    
    public float Speed;
    [SerializeField] GameObject initObject;
    InitGame initGame;

    // Start is called before the first frame update
    void Start()
    {
        
        transform.position = new Vector3(-100f, 240f, 0f);
        initObject = GameObject.Find("InitGame");
        initGame = initObject.GetComponent<InitGame>();



    }

    // Update is called once per frame
    void Update()
    {
        Speed = initGame.spaceshipSpeed;
        transform.Translate(Vector3.right * Time.deltaTime * Speed);

        float posX = transform.position.x;
        if (posX < 950)
        {
            transform.position = new Vector3(-100f, 240f, 0f);
        }


    }
}
