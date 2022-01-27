using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    Rigidbody _myRigidbody;

    void Start(){
        _myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var moveInput = Input.GetAxis("Horizontal");
        _myRigidbody.velocity = new Vector3(moveInput * moveSpeed, _myRigidbody.velocity.y, 0);
    }
}
