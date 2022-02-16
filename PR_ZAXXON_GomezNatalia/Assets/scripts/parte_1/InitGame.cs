using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitGame : MonoBehaviour
{

    public float spaceshipSpeed;
    public bool alive;


    AudioSource musicVolume;




    // Start is called before the first frame update
    void Start()
    {
        //Accedemos al componente de la música que está en el canvas
        musicVolume = GameObject.Find("Canvas").GetComponent<AudioSource>();
        //Ponemos el volumen al que tengamos configurado
        musicVolume.volume = Volumen.musicVolume;
        //Ponemos el slider al volumen configurado
        mySlider.value = Volumen.musicVolume;

        spaceshipSpeed = 25f;

        mySlider = GameObject.Find("Volumen").GetComponent<mySlider>();
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
        //Comprobar HS
        if (Score > GameManager.HighScore)
        {
            GameManager.HighScore = Score;

        }
        spaceshipSpeed = 0f;
        alive = false;
        GameObject.Find("NAVE MAYAFIX").SetActive(false);

    }

    public void SetVolume()
    {

        musicVolume.volume = volumeSlider.value;
    }





}
