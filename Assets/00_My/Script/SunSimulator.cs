using UnityEngine;
using System.Collections;

public class SunSimulator : MonoBehaviour {
	public float mSpeed = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = transform.rotation * Quaternion.Euler (mSpeed * Time.deltaTime, 0, 0);
	}
}
