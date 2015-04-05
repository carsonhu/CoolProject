﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject Hero;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Hero.transform.position + offset;
	}
}
