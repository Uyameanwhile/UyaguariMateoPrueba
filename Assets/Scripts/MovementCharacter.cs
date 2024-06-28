using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCharacter : MonoBehaviour
{
    public float velocidad = 3f;
    void Update()
    {
        PlayerMove();
    }
    void PlayerMove()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 movement = Vector3.back * horizontalInput * velocidad * Time.deltaTime;    
        transform.Translate(movement);

    }
}