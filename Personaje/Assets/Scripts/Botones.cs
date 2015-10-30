using UnityEngine;
using System.Collections;

public class Botones: MonoBehaviour {
	public float speed;
	public float dir;
	// Use this for initialization
	void Start () {
		speed = 3;
		dir = 1;
	}
	
	// Update is called once per frame
	void Update () {
		moverSiempre ();
	}
	//Funcion mueve al personaje
	public void moveL()
	{
		//Debug.Log ("Holiwi");
		//this.transform.Translate((Time.deltaTime * speed)* Vector3.left);
		dir = -1;
	}
	//Funcion mueve al personaje
	public void moveR()
	{
		//Debug.Log ("Holiwi");
		//this.transform.Translate((Time.deltaTime * speed)* Vector3.right);
		dir = 1;
	}
	public void moverSiempre ()
	{
		this.transform.Translate ((Time.deltaTime * speed * dir) * Vector3.right);
	}
}