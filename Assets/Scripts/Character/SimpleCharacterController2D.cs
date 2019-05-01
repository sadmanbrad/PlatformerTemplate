using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController2D : PhysicsObject {

	[SerializeField]
	private float walkSpeed;
	[SerializeField]
	private float jumpForce;
	
	public float walkSpeedMultiplayer;

	private bool wantToJump;

	Vector2 moveVector;

	protected override void ComputeVelocity() {
		if(grounded && wantToJump) {
			velocity.y = jumpForce;
		}
		moveVector.x = walkSpeedMultiplayer * moveVector.x;
		targetVelocity = moveVector;
		wantToJump = false;
	}

	public void Walk(float walkDirection) {
		moveVector.x = walkDirection * walkSpeed;
	}
	
	public void Jump() {
		wantToJump = true;
	}

}