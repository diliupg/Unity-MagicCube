using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color newColor; // The color you want to change to

    private Material ShapeMat; // Reference to the Material component

    private bool ColorChanged;

    private string ObjName = "Ground";


    private void Start()
    {
        ShapeMat = GetComponent<MeshRenderer>().material;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a specific tag or condition if needed
        // For example: if (collision.gameObject.tag == "Player")

        // Change the material color
        if (!ColorChanged)
        {
            if(collision.gameObject.tag == ObjName)
            {
                ColorChanged = true;
                ShapeMat.color = newColor;
            }
            
        }
            
    }

    private void OnCollisionExit(Collision collision)
    {
        // Reset the material color or perform any other actions if needed
        // For example: _renderer.material.color = Color.white
    }

}
