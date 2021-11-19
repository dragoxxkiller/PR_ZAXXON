using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nubbb : MonoBehaviour
{
    [SerializeField] GameObject nub1;
   

    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        Speed = 5;
        nub1.transform.position = new Vector3(-100f, 240f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * Speed);

        float posX = transform.position.x;
        if (posX < 950)
        {
            nub1.transform.position = new Vector3(-100f, 240f, 0f);
            
        }
    }
}
