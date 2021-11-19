using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIvidas : MonoBehaviour
{
    [SerializeField] Text ScoreText;
    float score = 0;
    [SerializeField] Image vidas;
    [SerializeField] Sprite[] monedas;
    
    public static int vidass = 3;

    InitGame initGame;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("Puntuacion");


    }

    // Update is called once per frame
    void Update()
    {
        if(vidass >= 0 && vidass < monedas.Length)
        {
            vidas.sprite = monedas[vidass];
        }
        

        print(vidass);

       ScoreText.text = "Score: " + score++;

    }

    IEnumerator Puntuacion()
    {
        
        
        yield return null;
        
    }

}
