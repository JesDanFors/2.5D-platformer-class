using System;
using UnityEngine;

public class PlayerController : MonoBehaviour{
    public Rigidbody MyRigidbody;
    
    public float moveSpeed = 5f;
    public float jumpForce = 500f;


    void Update(){
        var moveInput = Input.GetAxis("Horizontal");
        MyRigidbody.velocity = new Vector3(moveInput * moveSpeed, MyRigidbody.velocity.y, 0);

        var jumpInput = Input.GetKeyDown(KeyCode.Space);
        if (jumpInput){
            MyRigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
}
