using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3b : MonoBehaviour
{

    [SerializeField] int x = 5;
    [SerializeField] int y = 4;


    // Start is called before the first frame update
    void Start()
    {
        Operación();
    }


    void Operación()
    {
        int operacion;
        operacion = x * y;
        print(operacion);

        bool resultado = true ;

        //comprovación de par e impar
        if(operacion % 2 == 0)
        {

            print(resultado);

        }
        else
        {
            resultado = false;

            print(resultado);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
