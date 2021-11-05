using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIvidas : MonoBehaviour
{

    [SerializeField] Image vidas;
    [SerializeField] Sprite[] monedas;

    public static int vidass = 2;




    // Start is called before the first frame update
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {

        vidas.sprite = monedas[vidass];

        print(vidass);



    }
}
