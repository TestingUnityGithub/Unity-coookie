using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public GameObject cube;
	public Transform spawn;

	void Start()
	{
		Instantiate (cube, spawn.position, spawn.rotation);
    }
}