using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4a : MonoBehaviour
{

    bool interruptor = false;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Contador");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(interruptor == false)
            {
                StartCoroutine("Contador");
                interruptor = true;
            } else
            {
                StopCoroutine("Contador");
                interruptor = false;
            }
        }
    }

    IEnumerator Contador()
    {

        int seg = 0;
        int min = 0;
        int hora = 0;

        while (true)
        {

            print(hora.ToString("D2") + ":" + min.ToString("D2") + ":" + seg.ToString("D2"));
            seg++;

            yield return new WaitForSeconds(1f);

            if (seg >= 59)
            {
                seg = 0;
                min++;

                if (min >= 59)
                {

                    min = 0;
                    hora++;

                    if (hora >= 59)
                    {
                        StopCoroutine("Contador");
                    }
                }
            }

        }




    }

}
