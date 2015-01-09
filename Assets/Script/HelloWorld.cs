using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour 
{
	public GameObject cube;

	void Start () 
	{
		Invoke ("PingPong");
	}
	
	void Update () 
	{
		transform.Translate (Vector3.left);
		Debug.Log ("Nitin");
	}

	void PingPong()
	{
		PlayerPrefs.SetInt ("Hello World value ", 1);
	}
}
