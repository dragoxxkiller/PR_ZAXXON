using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    [SerializeField] Transform player;
    [SerializeField] GameObject playerObject;

    [SerializeField] float smoothVelocity = 0.1F;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;
    [SerializeField] Transform playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        










    }

    // Update is called once per frame
    void Update()
    {

        // Otra forma de seguir a la nave, mas brusca.
        /*transform.LookAt(player);
        transform.position = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y + 1, transform.position.z);*/



        Vector3 targetPosition = new Vector3(playerPosition.transform.position.x, playerPosition.transform.position.y + 1, playerPosition.transform.position.z - 5);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);

    }



}
