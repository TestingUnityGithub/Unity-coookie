using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

	public GameObject cube;
	void Start () {

	}
	

	void Update () {
		transform.Translate (Vector3.left);
		Debug.Log ("Nitin");
		//cube.transform.localEulerangles (0, 8, 0);
	}
}
