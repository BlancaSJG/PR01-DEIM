using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3b2 : MonoBehaviour
{


    [SerializeField] int x = 5;
    [SerializeField] int y = 4;

    // Start is called before the first frame update
    void Start()
    {
        Operaciones();  
    }


    [SerializeField] bool multiplicar = true;
    [SerializeField] bool dividir = true;
    [SerializeField] bool sumar = true;
    [SerializeField] bool restar = true;

    void Operaciones()
    {

       

        int operacion;

        if (multiplicar)
        {
            operacion = x * y;

            print(operacion);
        }

        if (dividir)
        {
            operacion = x / y;

            print(operacion);
        }

        if (sumar)
        {
            operacion = x + y;

            print(operacion);
        }

        if (restar)
        {
            operacion = x - y;

            print(operacion);
        }
        

















    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
