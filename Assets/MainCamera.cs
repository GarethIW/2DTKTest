﻿using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, transform.position.y, -200f + Mathf.Sin(Time.realtimeSinceStartup)*100f);
	}
}