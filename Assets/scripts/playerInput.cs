using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// krijgt input van het spel
public class playerInput : MonoBehaviour {

    private playerMovement _playerMovement;

   

    float xInput;
    float yInput;

   void Awake()
    {
        _playerMovement = GetComponent<playerMovement>();
     
    }
 
    

    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");


        if (Input.GetKeyDown("a"))
            {
            transform.rotation = Quaternion.AngleAxis(270,Vector3.up);
            
        }

        if (Input.GetKeyDown("d"))
        {
            transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
        }
        
        if (Input.GetKeyDown("s"))
        {
            transform.rotation = Quaternion.AngleAxis(180, Vector3.up);
        }
        if (Input.GetKeyDown("w"))
        {
            transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
        }
       
        
        if (Input.GetKey("w") && Input.GetKey("a"))
        {
            transform.rotation = Quaternion.AngleAxis(315, Vector3.up);
        }

        if (Input.GetKey("a") && Input.GetKey("s"))
        {
            transform.rotation = Quaternion.AngleAxis(225, Vector3.up);
        }

        if (Input.GetKey("d") && Input.GetKey("s"))
        {
            transform.rotation = Quaternion.AngleAxis(135, Vector3.up);
        }

        if (Input.GetKey("d") && Input.GetKey("w"))
        {
            transform.rotation = Quaternion.AngleAxis(45, Vector3.up);
        }

        //convert pixel coords of ouse to ray.
        // a ray is an invisible line betweet two points


        //  Debug.DrawRay(ray.origin, ray.direction * 100);



        // _playerMovement.LookAt(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        _playerMovement.Move(new Vector3(xInput, 0f, yInput));
    }
}
