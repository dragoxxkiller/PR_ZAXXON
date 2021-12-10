using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciador : MonoBehaviour
{

    [SerializeField] GameObject Plataforma;
    [SerializeField] GameObject trees1Dia;
    [SerializeField] GameObject trees2Dia;
    [SerializeField] GameObject trees1Noche;
    [SerializeField] GameObject trees2Noche;
    [SerializeField] GameObject foreground;

    float intervalo;

    // Start is called before the first frame update
    void Start()
    {

        Instantiate(Plataforma);
        StartCoroutine("CrearArbol1");
        StartCoroutine("CrearArbol2");
    }

    // Update is called once per frame
    void Update()
    {



    }
    IEnumerator CrearArbol1()
    {
        
        while (true)
        {
        Instantiate(trees1Dia);


       

        intervalo = 1f;

        yield return new WaitForSeconds(intervalo);

        }
        
    }


    IEnumerator CrearArbol2()
    {
        
       while (true)
        {
        Instantiate(trees2Dia);


        

        intervalo = 0.5f;

        yield return new WaitForSeconds(intervalo);
        }
        
    }

    /*IEnumerator CrearArbol3()
    {
        
    if(true)
        {
        Instantiate(trees1Noche);


        

        intervalo = 1f;

        yield return new WaitForSeconds(intervalo);
        }
    }
    IEnumerator CrearArbol4()
    {
        
    if(true)
         {
        Instantiate(trees2Noche);


       

        intervalo = 0.5f;

        yield return new WaitForSeconds(intervalo);
        }
    }*/



}

