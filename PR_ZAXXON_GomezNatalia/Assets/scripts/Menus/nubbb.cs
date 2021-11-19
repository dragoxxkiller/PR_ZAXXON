using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nubbb : MonoBehaviour
{
    [SerializeField] GameObject nub1;
    [SerializeField] GameObject nub2;
    [SerializeField] GameObject nub3;
    [SerializeField] GameObject nub4;

    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        Speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * Speed);

        float posX = transform.position.x;
        if (posX < 950)
        {
            nub1.transform.position = new Vector3(-100f, 240f, 0f);
            nub2.transform.position = new Vector3(-100f, 72f, 0f);
            nub3.transform.position = new Vector3(-100f, 116f, 0f);
            nub4.transform.position = new Vector3(-100f, 76f, 0f);
        }
    }
}
