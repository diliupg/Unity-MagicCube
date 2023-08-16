using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    Rigidbody _myRb;
    public float forceMagnitude = 2.5f;

    public Material _shapeMat;

    void Start()
    {
        _myRb = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
        ShapeMovement();
        ColorBasedOnPosition();
    }

    public void IncreaseForce(float addedForce)
    {
        forceMagnitude += addedForce;
    }
    
    private void ShapeMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _myRb.AddForce(Vector3.left * forceMagnitude);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            _myRb.AddForce(Vector3.right * forceMagnitude);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            _myRb.AddForce(Vector3.up * forceMagnitude);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            _myRb.AddForce(Vector3.down * forceMagnitude);
        }
    }

    private void ColorBasedOnPosition()
    {
        if(transform.position.y < 3)
            _shapeMat.color = Color.yellow;
        
        if(transform.position.y > 3)
            _shapeMat.color = Color.black;
        
        if(transform.position.x < 3)
            _shapeMat.color = Color.cyan;
        
        if(transform.position.x > 3)
            _shapeMat.color = Color.white;
            
    }
}
