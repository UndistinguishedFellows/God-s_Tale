using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MapCreationType
{
    GridSize = 0,
    WorldSize = 1
}

public class MapData : ScriptableObject
{
    public int GridWidth { get; private set; }
    public int GridHeight { get; private set; }
    public int WorldWidth { get; private set; }
    public int WorldHeight { get; private set; }
    public float TileWidth { get { return m_tileWidth; } }
    public float TileHeight { get { return m_tileHeight; } }
    public float TileOffset { get { return m_tileOffset; } }
    public TileMap TileMap { get { return m_tileMap; } }
    
    private int m_gridWidth = 0, m_gridtHeight = 0;         // TODO: Create custom inspector to serialize only one set of properties according to map creation type
    private float m_worldWidth = 0.0f, m_worldHeight = 0.0f;      // TODO: Create custom inspector to serialize only one set of properties according to map creation type
    [SerializeField] private float m_tileWidth = 0.0f, m_tileHeight = 0.0f;
    [SerializeField] private float m_tileOffset = 0.0f;
    [SerializeField] private TileMap m_tileMap = null;
    [SerializeField] private MapCreationType m_mapCreationType = MapCreationType.GridSize;

    private void CalcMapSize()
    {
        if(m_mapCreationType == MapCreationType.GridSize)
        {
            m_worldWidth = (m_gridWidth * m_tileWidth) + (m_tileOffset * m_gridWidth);
            m_worldHeight = (m_gridtHeight * m_tileHeight) + (m_tileOffset * m_gridtHeight);
        }
        else if(m_mapCreationType == MapCreationType.WorldSize)
        {
            // TODO
        }
    }
}
