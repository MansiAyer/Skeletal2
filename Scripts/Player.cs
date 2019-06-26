using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public CharacterController control;
    public Vector3 move;
    public float speed = 3.0f;
    public float verticalVelocity = 0.0f;
    public float gravity = 12.0f;
	// Use this for initialization
	void Start () {
        control = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
        move = Vector3.zero;

        if (control.isGrounded)
        {
            verticalVelocity = 0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        //x - Left and Right
        move.x = Input.GetAxisRaw("Horizontal");
        
        //y - Up and Down
        move.y = verticalVelocity;

        //z
        move.z = speed;
        control.Move(move * Time.deltaTime);
	}
}
