﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraLook : MonoBehaviour {

	public float YSensitivity;
	private float yRotate;
	public Slider YSensitivitySlider;

	void Update () {
		YSensitivity = YSensitivitySlider.value;
		yRotate = Mathf.Min (50, Mathf.Max (-50, yRotate + (-Input.GetAxis ("Mouse Y") * YSensitivity)));
		transform.localRotation = Quaternion.Euler (yRotate, 0, 0);
	}
}
