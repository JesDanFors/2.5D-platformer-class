using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImmediateJump : MonoBehaviour{
    public float jumpForce = 500f;
    
    Rigidbody _myRigidbody;
    void Start(){
        _myRigidbody = GetComponent<Rigidbody>();
    }
    void Update(){
        var jumpInput = Input.GetKeyDown(KeyCode.Space);
        if (jumpInput){
            _myRigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
}
