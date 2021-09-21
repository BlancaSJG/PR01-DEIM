using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3a : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Saludar("amigo");
    }


    void Saludar(string nombre)
    {
        print("Hola "+ nombre);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
