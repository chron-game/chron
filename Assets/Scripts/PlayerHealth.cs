using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public const int maxHealth = 100;
	public int currentHealth;
	public Slider healthSlider;

	void Awake() {
		currentHealth = maxHealth;
	}

		void Update() {
		healthSlider.value = currentHealth;
	}

	public void TakeDamage(int amount) {
		currentHealth -= amount;
		if (currentHealth <= 0) {
			currentHealth = maxHealth;
		}
	}
}
