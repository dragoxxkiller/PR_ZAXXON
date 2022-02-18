using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitGame : MonoBehaviour
{

    public float spaceshipSpeed;
    public bool alive;


    AudioSource musicVolume;

    public float score;
    public float mySlider;


    // Start is called before the first frame update
    void Start()
    {

        
        musicVolume = GameObject.Find("Sonido_empty").GetComponent<AudioSource>();
        
        musicVolume.volume = GameManager.musicVolume;
       

        spaceshipSpeed = 25f;

    }

    // Update is called once per frame
    void Update()
    {


        if (alive)
        {
            spaceshipSpeed += 0.005f;
        }


    }

    void Morir()
    {
        score = GameObject.Find("Canvas").GetComponent<UIvidas>().score;
        //Comprobar HS
        if (score > GameManager.HighScore)
        {
            GameManager.HighScore = score;

        }
        spaceshipSpeed = 0f;
        alive = false;
        GameObject.Find("NAVE MAYAFIX").SetActive(false);

    }






}
