using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botone_UI : MonoBehaviour
{

   /* [SerializeField] Text volumenText;
    float volumen;
    [SerializeField] Slider mySlider;*/



    public void Empezar()
    {
        SceneManager.LoadScene("Parte_1");
    }



    public void AlMenu()
    {
        SceneManager.LoadScene("Menuu");
    }



    public void CerrarJuego()
    {

    }



   /* public void SubirVolumen()
    {
        volumen = (mySlider.value);
        volumenText.text = "Volumen:" + volumen;
    }*/



    // Start is called before the first frame update
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {
        



    }
}
