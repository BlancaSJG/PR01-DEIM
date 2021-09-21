using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3c : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Contador");
    }



    IEnumerator Contador()
    {

        int contador = 0;

        while(true)
        {
            
            print(contador);
            contador++;

            yield return new WaitForSeconds(1f);

            if (contador >= 30)
            {
                StopCoroutine("Contador");
            }
        }




    }



    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
