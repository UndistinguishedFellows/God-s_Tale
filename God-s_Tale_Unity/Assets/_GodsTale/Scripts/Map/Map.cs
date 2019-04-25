using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;

public class Map // TODO: Maybe inherit from ScriptableObject to serialize???
{
    public Map(in StringConstant[] tilesIds, in MapData mapData)
    {
        m_tilesIDs = tilesIds;
        m_mapData = mapData;
    }

    public void SetTile(Tile tile)
    {
        m_map[tile.MapCoordinates.GetIndex(m_mapData)] = tile;
    }

    public Tile GetTile(MapCoordinates coords)
    {
        int index = coords.GetIndex(m_mapData);
        return IsIndexValid(index) ? m_map[index] : null;
    }

    public Tile GetTile(int index)
    {
        return IsIndexValid(index) ? m_map[index] : null;
    }
    
    private bool IsIndexValid(int index)
    {
        return index >= 0 && index < m_mapData.GridWidth * m_mapData.GridHeight;
    }

    private StringConstant[] m_tilesIDs = null;
    private Tile[] m_map = null;
    private MapData m_mapData = null;
}
