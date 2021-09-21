using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2d : MonoBehaviour
{



    int x = 0;

    // Start is called before the first frame update
    void Start()
    {
        int random = Random.Range(1, 30);


        while(x <= random)
        {
            print(x);
            x++;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
