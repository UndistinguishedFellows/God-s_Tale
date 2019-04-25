using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Vector3 WorldPosition { get { return transform.position; } }
    public TileData TileData { get; private set; }
    public MapCoordinates MapCoordinates { get; private set; }
    
    public void SetTile(TileData tileData, MapCoordinates mapCoordinates)
    {
        TileData = tileData;
        MapCoordinates = mapCoordinates;
    }
}
