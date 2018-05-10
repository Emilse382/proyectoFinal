using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {
	public float velocidad=50f;
	public GameObject este;

	// Use this for initialization
	public void Start () {
	
	}
	
	// Update is called once per frame
	public void Update () {
		transform.position -= transform.up * velocidad * Time.deltaTime;

		if (transform.position.y < -5) {
			DestroyImmediate(este);
		}
	}
}
