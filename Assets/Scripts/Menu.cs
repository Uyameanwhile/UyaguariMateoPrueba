using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Inicio()
    {
        SceneManager.LoadScene(0);
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene(1);
    }
}
