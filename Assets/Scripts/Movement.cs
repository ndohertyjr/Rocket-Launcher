using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Movement : MonoBehaviour
{
    [SerializeField] private float rocketSpeed = 10f;

    private float xVal;
    private float yVal;
    private float zVal;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    private void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
        }
    }

    private void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            
        }
    }
}
