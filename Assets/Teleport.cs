using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	public GameObject invPortal;
	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "player") 
		{
			StartCoroutine (Teleportation());
		}
	}

	IEnumerator Teleportation()
	{
		yield return new WaitForSeconds (0.5f);
		player.transform.position = new Vector2(invPortal.transform.position.x, invPortal.transform.position.y);
	}
}
