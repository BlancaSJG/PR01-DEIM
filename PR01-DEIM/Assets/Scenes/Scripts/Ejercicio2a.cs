using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2a : MonoBehaviour
{

    int n = 0;


    // Start is called before the first frame update
    void Start()
    {
        print("Esto es un contador");
        
    }

    // Update is called once per frame
    void Update()
    {
        while(n <= 15)
        {
            print(n);
            n++;
        }
    }
}
