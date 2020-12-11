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

	public int maxHealth = 100;
	public int currentHealth;

	public int maxMana = 100;
	public int currentMana;

	public int maxXp = 1000;
	public int currentXp;

	public HealthBarScript healthBar;
	public ManaBarScript manaBar;
	public ExpBarScript xpBar;

	private Vector2 movement;

	private void Start()
	{
		currentHealth = maxHealth;
		currentMana = maxMana;
		currentXp = 0;

		healthBar.SetMaxHealth(maxHealth);
		manaBar.setMaxMana(maxMana);

	}

	private void Update()
	{
		movement.x = Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");

		if (movement != Vector2.zero)
		{
			animator.SetFloat("Horizontal", movement.x);
			animator.SetFloat("Vertical", movement.y);
		}

		if (Input.GetKeyDown(KeyCode.Space)) TakeDamage(20);

		animator.SetFloat("Speed", movement.sqrMagnitude);
	}

	private void FixedUpdate()
	{
		body.MovePosition(body.position + movement * moveSpeed * Time.fixedDeltaTime);
	}

	private void changeItem(Item i)
	{

	}
		
	private void TakeDamage(int damage)
	{
		currentHealth -= damage;
		healthBar.SetHealth(currentHealth);
	}

}
