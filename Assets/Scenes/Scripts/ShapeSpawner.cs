 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    public Shape[] ShapePrefabs;

    float forcePlus = 5.8f;

    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        Instantiator ();
        ForceIncreaser();

    }

    private void ForceIncreaser()
    {
        if(Input.GetKeyDown(KeyCode.F)) 
        {
            for(int i = 0; i < ShapePrefabs.Length; i++)
            {
                ShapePrefabs[i].IncreaseForce(forcePlus);
            }
        }
    }

    private void Instantiator()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < ShapePrefabs.Length; i++)
            {
                Instantiate(ShapePrefabs[i]);
            }
        }
    }
}
