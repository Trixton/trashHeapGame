using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform transform;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 30;
    }

    // Update is called once per frame
    void Update()
    {
        float playerSpeed = Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, playerSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -playerSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-playerSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(playerSpeed, 0, 0);
        }
    }
}
