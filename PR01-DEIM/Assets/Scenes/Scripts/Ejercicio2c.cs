using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2c : MonoBehaviour
{

    


    // Start is called before the first frame update
    void Start()
    {

        print("El contador empieza");
        for (int contador = 0; contador <= 15; contador++)
        {
            print(contador);

            if (contador == 10)
            {
                print("Queda poco para que el contador termine");
            }else if(contador == 15) 
            {

                print("El contador ha terminado");
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
