using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    const float MovementSensitivity = 20;

	public float XSensitivity;
	public float jumpHeight;
	private Rigidbody rb;
	private float lookX;
	private float XMovement;
	private float ZMovement;
	public Slider XSensitivitySlider;
	public bool grounded = true;
	public Text XSens;

	void Start() {
		rb = GetComponent<Rigidbody>();
		Cursor.visible = false;
	}

	void Update() {
		XSensitivity = XSensitivitySlider.value;
		XSens.text = XSensitivity.ToString();
		lookX = Input.GetAxis ("Mouse X") * XSensitivity;
		rb.constraints = RigidbodyConstraints.FreezeRotation;
		XMovement = Input.GetAxis ("Horizontal") * Time.deltaTime * 3.0f;
		ZMovement = Input.GetAxis ("Vertical") * Time.deltaTime * 3.0f;
		transform.Rotate (0, lookX, 0); 
		transform.Translate (MovementSensitivity * XMovement, 0, MovementSensitivity * ZMovement);
		if (Input.GetKeyDown (KeyCode.Space) && grounded == true) {
			rb.velocity = new Vector3 (0, 10 * jumpHeight * Time.deltaTime, 0);
			grounded = false;
		}
	}

	void OnCollisionEnter (Collision Col) {
		if (Col.gameObject.tag == "Ground") {
			grounded = true;
		}
	}
}