using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DetectedCollision : MonoBehaviour
{
    public Text Puntaje;
    public float Puntos = 0f;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Puntos++;
        Puntaje.text = Puntos.ToString();
    }

}
