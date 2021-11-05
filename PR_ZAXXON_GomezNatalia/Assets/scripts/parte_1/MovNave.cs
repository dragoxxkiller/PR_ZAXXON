using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovNave : MonoBehaviour
{
    public float SpeedForward;
    public float SpeedSides;
    public float SpeedHeight;
    public float RotationSpeed;

    InitGame initGame;

    private Vector3 cubePosition = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {

        

        SpeedHeight = 10F;

        SpeedSides = 10f;

        SpeedForward = 5f;

        RotationSpeed = 100f;

        transform.position = new Vector3(0f, 1f, 0f);



        initGame = GameObject.Find("InitGame").GetComponent<InitGame>();
    }

    // Update is called once per frame
    void Update()
    {

        MoverNarve();
        

    }

    void MoverNarve()
    {
        float desp1H = Input.GetAxis("Horizontal");
        float desp1V = Input.GetAxis("Vertical");
        float desp1F = Input.GetAxis("Forward");
        float desp1R = Input.GetAxis("Rotacion");







        float posX = transform.position.x;
        float posY = transform.position.y;
        float posZ = transform.position.z;


        //print("PosX: " + posX + " - DesplH: " + desp1H);


        if ((posX <= 14f || desp1H < 0f) && (posX > -14f || desp1H > 0f))
        {
            transform.Translate(Vector3.right * Time.deltaTime * SpeedSides * desp1H, Space.World);
        }



        if ((posY <= 20f || desp1V < 0f) && (posY > 1f || desp1V > 0f))
        {
            transform.Translate(Vector3.up * Time.deltaTime * SpeedHeight * desp1V, Space.World);
        }



        if ((posZ <= 10f || desp1F < 0f) && (posZ > 1f || desp1F > 0f))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * SpeedForward * desp1F, Space.World);
        }



        transform.Rotate(0F, 0F, desp1R * Time.deltaTime * RotationSpeed);
        //print(desp1R);


       
    }


    void OnTriggerEnter(Collider other)
    {
        print("He chocao con " + other.gameObject.tag);
        if (other.gameObject.tag == "Obstaculo")
        {


            UIvidas.vidass--;


            initGame.spaceshipSpeed = 0f;

            initGame.alive = false;


           


        }
    }




}
