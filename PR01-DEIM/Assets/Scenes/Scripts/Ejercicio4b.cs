using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4b : MonoBehaviour
{
    [SerializeField] Vector3 objectPosition = new Vector3(0f, 0f, 0f);
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = objectPosition;
        speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.A))
         {
            speed = 2;

        }
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * speed);


        if (Input.GetKeyDown(KeyCode.W))
         {
            speed = 2;

        }
        transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * speed);

        
    }
}
