using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Author: Zachary Knoblauch
/// </summary>
public class PlayerController : MonoBehaviour
{

	public Rigidbody2D body;
	public Animator animator;

	public float moveSpeed = 5f;

	private Vector2 movement;

	private void Update()
	{
		movement.x = Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");

		if (movement != Vector2.zero)
		{
			animator.SetFloat("Horizontal", movement.x);
			animator.SetFloat("Vertical", movement.y);
		}

		animator.SetFloat("Speed", movement.sqrMagnitude);
	}

	private void FixedUpdate()
	{
		body.MovePosition(body.position + movement * moveSpeed * Time.fixedDeltaTime);
	}

}
