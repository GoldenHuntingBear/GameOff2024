using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HoleController : MonoBehaviour
{
    public Tilemap tilemap;
    private TileBase original_tile;
    private Vector3Int tile_position;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position);
        tile_position = Vector3Int.FloorToInt(transform.position);
        original_tile = tilemap.GetTile(tile_position);
        GetComponentInChildren<SpriteRenderer>().sprite = tilemap.GetSprite(tile_position);
    }

    public void Activate()
    {
        tilemap.SetTile(tile_position, null);
    }
    public void Deactivate()
    {
        tilemap.SetTile(tile_position, original_tile);
    }
}
