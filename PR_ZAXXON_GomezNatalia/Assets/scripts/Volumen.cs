using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{
    [SerializeField] Text volumenText;
    [SerializeField] Slider mySlider;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        mySlider.value = GameManager.musicVolume;
        volumenText.text = "Volumen:" + mySlider.value;

        audioSource = GetComponent<AudioSource>();

        audioSource.volume = mySlider.value;
    }

    // Update is called once per frame
    void Update()
    {

        

    }
    public void SubirVolumen()
    {
        GameManager.musicVolume = ((int)
            mySlider.value);
        volumenText.text = "Volumen:" + GameManager.musicVolume;
    }
}
