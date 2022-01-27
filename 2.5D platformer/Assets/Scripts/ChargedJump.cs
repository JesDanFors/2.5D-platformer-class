using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargedJump : MonoBehaviour{
   [SerializeField] float minJumpForce = 100f;
   [SerializeField] float maxJumpForce = 1000f;
   [SerializeField] float chargeTime = 1f;
   
   Rigidbody _myRigidbody;
   GroundCheck _groundCheck;

   float jumpCharge;

   void Start(){
      _myRigidbody = GetComponent<Rigidbody>();
      _groundCheck = _groundCheck;
   }

   void Update(){
      if (Input.GetKeyDown(KeyCode.Space)){
         jumpCharge += Time.deltaTime / chargeTime;
      }

      if ( Input.GetKeyUp(KeyCode.Space) && _groundCheck.IsGrounded){
         var jumpForce = Mathf.Lerp(minJumpForce, maxJumpForce, jumpCharge);
         
      }
   }
}
