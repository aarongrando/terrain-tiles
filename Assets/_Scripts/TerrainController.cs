using UnityEngine;
using System.Collections;


public class TerrainController : MonoBehaviour {
	
	private GameObject self;

	// Use this for initialization
	void Start () {
		self = gameObject;
	}
	
	void OnMouseDown() {
		pop_out ();
	}

	void pop_in () {
		gameObject.transform.localScale = new Vector3(1, 1, 1);
	}

	void pop_out () {
		LeanTween.rotate (self, new Vector3(0, 0, 90), 1.5F);
		LeanTween.scale (self, new Vector3(0, 0, 0), 1.5F);
		// gameObject.transform.localScale = new Vector3(0,0,0);
	}

}
