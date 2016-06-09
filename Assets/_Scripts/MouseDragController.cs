using UnityEngine;
using System.Collections;

public class MouseDragController : MonoBehaviour {

    public static GameObject itemBeingDragged;
    public GameObject hand_object;

    float distance = 14.8F;
    private HandController hand;
    private GameObject terrain_hover;

    Vector3 startPosition;

    void Start()
    {
        hand = hand_object.GetComponent<HandController>();
    }

    public void OnMouseDown()
    {
        itemBeingDragged = gameObject;
        hand.selected_card = itemBeingDragged;
        startPosition = transform.position;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    void OnMouseDrag()
    {
        Ray ray;
        RaycastHit hit;

        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
        ray = new Ray (itemBeingDragged.transform.position, -Vector3.up);
        if (Physics.Raycast(ray, out hit))
        {
            terrain_hover = GameObject.Find(hit.collider.name);

            if (terrain_hover.tag == "Tile")
            {
                print(terrain_hover.ToString());
            } else
            {
                terrain_hover = null;
            }

        }
    }

    public void OnMouseUp()
    {

        if (terrain_hover != null)
        {
            // Set terrain to current card value
            terrain_hover.GetComponent<TerrainController>().tile_status = itemBeingDragged.GetComponent<CardController>().card_value;

            // Reset card value
            itemBeingDragged.GetComponent<CardController>().card_value = "";
 
        }

        // Reset objects
        itemBeingDragged = null;
        hand.selected_card = itemBeingDragged;
        GetComponent<CanvasGroup>().blocksRaycasts = true;

        if (transform.position != startPosition)
        {
            transform.position = startPosition;

        }
    }




}
