using UnityEngine;
using System.Collections;


public class TerrainController : MonoBehaviour {

    public string tile_status = "G";
    public Material[] materials;
    public GameObject hand;

	private GameObject self;
    private Renderer tile_renderer;
    public GameObject hovering_card;

    // Use this for initialization
    void Start () {
		self = gameObject;
        tile_renderer = gameObject.GetComponent<Renderer>();

    }

    void Update ()
    {
        switch (tile_status) {
            case "G":
                tile_renderer.material = materials[0];
                break;
            case "M":
                tile_renderer.material = materials[1];
                break;
            case "T":
                tile_renderer.material = materials[2];
                break;
            case "R":
                tile_renderer.material = materials[3];
                break;
        }
    }
	
	void OnMouseDown() {
		pop_out ();
	}

    void OnMouseOver()
    {
        hovering_card = hand.GetComponent<HandController>().selected_card;
        
    }

    void OnMouseExit()
    {
        hovering_card = null;
    }

    void pop_in ()
    {
        gameObject.transform.localScale = new Vector3(0, 0, 0);
        LeanTween.rotate(self, new Vector3(0, 0, -90), 0.5F);
        LeanTween.scale(self, new Vector3(1, 1, 1), 0.5F);
    }

	void pop_out () {
		LeanTween.rotate (self, new Vector3 (0, 0, 90), 0.5F);
		LeanTween.scale (self, new Vector3 (0, 0, 0), 0.5F);
		// gameObject.transform.localScale = new Vector3(0,0,0);
	}

}
