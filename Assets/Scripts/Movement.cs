using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Movement : MonoBehaviour
{
    [SerializeField] private float rocketThrust = 2000.0f;
    [SerializeField] private float rotationSpeed = 100.0f;
    private AudioSource rocketLaunchSound;
    private bool audioPlaying = false;
    private Rigidbody rocketBody;
    private float xVal;
    private float yVal;
    private float zVal;
    
    // Start is called before the first frame update
    void Start()
    {
        rocketBody = GetComponent<Rigidbody>();
        rocketLaunchSound = GetComponent<AudioSource>();
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
            rocketBody.AddRelativeForce(new Vector3(0f,rocketThrust * Time.deltaTime,0f));

            if (!rocketLaunchSound.isPlaying)
            {
                rocketLaunchSound.Play();
            }
            
            
        }
        else
        {
            rocketLaunchSound.Stop();
        }
        
        
    }

    private void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-rotationSpeed);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(rotationSpeed);
        }
    }

    private void ApplyRotation(float rotationThisFrame)
    {
        rocketBody.freezeRotation = true;
        transform.Rotate(Vector3.back * rotationThisFrame * Time.deltaTime);
        rocketBody.freezeRotation = false;
    }
}
