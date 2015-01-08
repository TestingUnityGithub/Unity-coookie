using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {


	void Start () {
		public GameObject cube;
	}
	

	void Update () {
		transform.Translate (Vector3.left);
		Debug.Log ("Nitin");
		cube.transform.localEulerangles (0, 8, 0);
	}
}
