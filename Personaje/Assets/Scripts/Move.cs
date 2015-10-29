using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		speed = 5;
	}
	
	// Update is called once per frame
	void Update () {
		moveForward ();
	}
	//Funcion mueve al personaje
	public void moveForward()
	{
		Debug.Log ("Holiwi");
		this.transform.Translate((Time.deltaTime * speed)* Vector3.down);
	}
}
