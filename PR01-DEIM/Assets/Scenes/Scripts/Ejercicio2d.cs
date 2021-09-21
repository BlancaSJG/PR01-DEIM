using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2d : MonoBehaviour
{

    int random;

    [SerializeField] int x = 0;

    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(1, 30);


        while(x != random)
        {
            random = Random.Range(1, 30);
            print(random);
            
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
