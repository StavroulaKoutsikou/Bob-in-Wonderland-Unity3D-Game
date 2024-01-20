using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob_movement : MonoBehaviour
{
    public float moveSpeed = 500;  // Ταχύτητα κίνησης του Bob
    private Renderer cubeRenderer;  // Ο Renderer του κύβου

    
    void Update()
    {
        // Κίνηση παράλληλα στον άξονα x
        if (Input.GetKey("a") && transform.position.x > -285)
        {
            
            transform.Translate(Vector3.left  * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey("d")&& transform.position.x < 485)
        {
            
            transform.Translate(Vector3.right  * moveSpeed * Time.deltaTime);
        }


        // Κίνηση παράλληλα στον άξονα z
        if (Input.GetKey("s") && transform.position.z < 550)
        {
            
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey("x") && transform.position.z > -245)
        {
            
            transform.Translate(Vector3.back  * moveSpeed * Time.deltaTime);
        }

        // Κίνηση παράλληλα στον άξονα y 
        if (Input.GetKey("w"))
        {
            
            transform.Translate(Vector3.up  * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey("e") && transform.position.y > -118)
        {
            
            transform.Translate(Vector3.down  * moveSpeed * Time.deltaTime);
        }



        
        
    }


}






