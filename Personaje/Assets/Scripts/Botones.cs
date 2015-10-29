using UnityEngine;
using System.Collections;

public class Botones: MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		speed = 5;
	}
	
	// Update is called once per frame
	void Update () {
		//SmoveForward ();
	}
	//Funcion mueve al personaje
	public void moveL()
	{
		Debug.Log ("Holiwi");
		this.transform.Translate((Time.deltaTime * speed)* Vector3.left);
	}
	//Funcion mueve al personaje
	public void moveR()
	{
		Debug.Log ("Holiwi");
		this.transform.Translate((Time.deltaTime * speed)* Vector3.right);
	}
}