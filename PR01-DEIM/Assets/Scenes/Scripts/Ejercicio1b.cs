using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1b : MonoBehaviour
{

    [SerializeField] int n = 5;
    [SerializeField] float d = 10f;
    [SerializeField] bool despierto = false;
    [SerializeField] string texto = "Hola mundo";

    [SerializeField] bool unity = false;

    // Start is called before the first frame update
    void Start()
    {

        

        if (unity == false)
        {
            int n = 3;
            float d = 5f;
            bool despierto = true;
            string texto = "Hola buenas";



            print(n);
            print(d);
            print(despierto);
            print(texto);
        }
        else
        {
            print(n);
            print(d);
            print(despierto);
            print(texto);

        }
        
        
       
    }

   

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
