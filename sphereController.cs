using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereController : MonoBehaviour {
    private Rigidbody rb;
    public int speed;


    void Start () {
        rb = GetComponent<Rigidbody>();
        
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float horiInput = Input.GetAxis("Horizontal");
         float vertInput =Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horiInput, 0, vertInput);
        rb.AddForce(movement * speed);
       
    }
   
   

        
        
   
    
}

