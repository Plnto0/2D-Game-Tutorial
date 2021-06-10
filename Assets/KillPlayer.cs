using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

	public int Respawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Player") 
		{
			Application.LoadLevel("Tutorial");
		}
	}
}
