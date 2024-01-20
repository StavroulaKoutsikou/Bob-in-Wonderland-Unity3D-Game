using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public Material red; // Assign the red material from the Unity Editor
    public Material blue;
    public Material golden;
    public Material purple;

    private Material bob_white; // Store the default material of "Bob"
    private bool hasChangedColor = false;

    void Start()
    {
        // Store the default material of "Bob"
        Renderer bobRenderer = GetComponent<Renderer>();
        if (bobRenderer != null)
        {
            bob_white = bobRenderer.material;
        }
        else
        {
            Debug.LogError("Bob does not have a Renderer component!");
        }
    }

private void OnTriggerEnter(Collider other)
{
    Debug.Log(other.name + " :Bob touches this cube with tag: " + other.tag);

    if (!hasChangedColor)
    {
        if (other.CompareTag("red_cube"))
        {
            Debug.Log("Changing material to red");
            ChangeColor(red);
        }
        else if (other.CompareTag("blue_cube"))
        {
            Debug.Log("Changing material to blue");
            ChangeColor(blue);
        }
        else if (other.CompareTag("golden_cube"))
        {
            Debug.Log("Changing material to golden");
            ChangeColor(golden);
        }
        else if (other.CompareTag("purple_cube"))
        {
            Debug.Log("Changing material to purple");
            ChangeColor(purple);
        }
    }
}


    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " :Bob does not touch this cube ");

        // Reset the flag when Bob leaves the cube
        if (other.CompareTag("red_cube") || other.CompareTag("blue_cube") ||
            other.CompareTag("golden_cube") || other.CompareTag("purple_cube"))
        {
            hasChangedColor = false;
        }
    }

    private void ChangeColor(Material newMaterial)
    {
        Debug.Log("Changing material");

        // Change the material of the entire "Bob" object to the specified material
        Renderer[] renderers = GetComponentsInChildren<Renderer>();

        foreach (Renderer renderer in renderers)
        {
            renderer.material = newMaterial;
        }

        // Set a flag to indicate that the color has been changed
        hasChangedColor = true;
    }
}
