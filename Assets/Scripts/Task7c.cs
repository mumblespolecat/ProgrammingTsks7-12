using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Task7c : MonoBehaviour
{
    public GameObject box;
    public float boxX, boxY, boxZ;
    
    // Start is called before the first frame update
    void Start()
    {
        // Instantiate(box, transform.position, transform.rotation);  //  this was an early instantiate effort to check the cube appeared

        Vector3 boxSize = GetComponent<Collider>().bounds.size;  // I couldn't work out how to get it working with Renderer (I tried for ages), but it worked with Collider, so I went with it !
        
        // Debug.Log(boxSize.x); //  these three were to check it worked ...
        // Debug.Log(boxSize.y);
        // Debug.Log(boxSize.z);
        
        boxX = boxSize.x;
        boxY = boxSize.y;
        boxZ = boxSize.z;

        for (int k = 0; k < 5; k++)
        {
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Instantiate(box, new Vector3(i * (boxX + (boxX * 0.1f)), j * (boxY + (boxY * 0.1f)), k * (boxZ + (boxZ * 0.1f))), Quaternion.identity);
                    //Instantiate(box, new Vector3(i * (boxX + (boxX * 0.1f)), 0, 0), Quaternion.identity);  // this works, in case the line above doesn't !
                }
            }
        }
        
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
