using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pared_mov : MonoBehaviour
{
    Renderer rend;

    [SerializeField] Vector2 despl;

    InitGame initGame;

    [SerializeField] float scrollSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();

        GameObject InitGame = GameObject.Find("InitGame");
        initGame = InitGame.GetComponent<InitGame>();

    }

    // Update is called once per frame
    void Update()
    {
        scrollSpeed = initGame.spaceshipSpeed / 8;
        float offset = Time.time * scrollSpeed;
        despl = new Vector2(-offset, 0);
        rend.material.SetTextureOffset("_MainTex", despl);



    }
}
