using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{



    float intervalo;
    [SerializeField] GameObject columna;
    [SerializeField] Transform instantiatePos;

    InitGame initGame;
    [SerializeField] GameObject initObject;

    IEnumerator CrearColumna()
    {
        while (true)
        {
            //print("Hola");
            float randomX = Random.Range(-14f, 14f);
            Vector3 newPos = new Vector3(randomX, instantiatePos.position.y, instantiatePos.position.z);
            Instantiate(columna, newPos, Quaternion.identity);
            
            yield return new WaitForSeconds(intervalo);

        }
    }

    // Start is called before the first frame update
    void Start()
    {



        // Intentando instanciar mas columnas cuanto mas rapido va

        initObject = GameObject.Find("InitGame");
        // initGame = initObject.GetComponent<spaceshipSpeed>();
        //* spaceshipSpeed

        intervalo = 0.4f ; 


        StartCoroutine("CrearColumna");
    }

    // Update is called once per frame
    void Update()
    {








    }
}


    
