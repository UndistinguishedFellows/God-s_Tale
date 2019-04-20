using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : ScriptableObject
{
    [SerializeField] private TileData m_tiles = null; // TODO: A tilemap should be something more complex than a single tiledata and should be able to expand this. For now  and testing is something
    // Actually this need to be a serializable dictionary
}
