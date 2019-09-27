using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 50f;
    public float turnSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
             transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
         }
          else if (Input.GetKey(KeyCode.S))
          {
              transform.Translate(Vector3.forward * Time.deltaTime * -moveSpeed);
          }

          if (Input.GetKey(KeyCode.A))
          {
              transform.Rotate(Vector3.up * Time.deltaTime * -turnSpeed);

          }
           else if (Input.GetKey(KeyCode.D))
         {
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);

         }

    }
}
