using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float degreesPerSecond=180;
    void Update()
    {
        transform.Rotate(new Vector3(0,0,degreesPerSecond)*Time.deltaTime);
    }
}
