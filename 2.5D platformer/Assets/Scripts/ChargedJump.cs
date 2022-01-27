using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargedJump : MonoBehaviour{
   Rigidbody _myRigidbody;
   GroundCheck _groundCheck;

   [SerializeField] float minJumpForce = 100f;
   [SerializeField] float maxJumpForce = 1000f;
   [SerializeField] float chargeTime = 1f;

   void Update(){
      
   }
}
