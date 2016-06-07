using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WorldController : MonoBehaviour {

    public int grass_strength;
    public int mountain_strength;
    public int tree_strength;

    private GameObject[] tiles;
    private GameObject start_tile;

    // Use this for initialization
    void Start () {

        int strength_total = grass_strength + mountain_strength + tree_strength;

        tiles = GameObject.FindGameObjectsWithTag("Tile");
        foreach(GameObject tile in tiles)
        {
 
            int randomIndex = UnityEngine.Random.Range(0, strength_total);

            string weighted_tile_choice = "G";

            if (randomIndex < grass_strength)
            {
                weighted_tile_choice = "G";
            } else if (randomIndex > grass_strength && randomIndex < (grass_strength + mountain_strength))
            {
                weighted_tile_choice = "M";
            }
            else if (randomIndex > (grass_strength + mountain_strength) && randomIndex < strength_total)
            {
                weighted_tile_choice = "T";
            }

            TerrainController tile_script = tile.GetComponent<TerrainController>();
            tile_script.tile_status = weighted_tile_choice;
        }

        start_tile = GameObject.FindGameObjectWithTag("StartTile");
        TerrainController start_tile_script = start_tile.GetComponent<TerrainController>();
        start_tile_script.tile_status = "R";

    }
	
	// Update is called once per frame
	void Update () {
	
	}


}
