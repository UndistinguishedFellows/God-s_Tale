using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map // TODO: Maybe inherit from ScriptableObject to serialize???
{
    public Map(in Tile[] tiles, in MapData mapData)
    {
        m_tileMap = tiles;
        m_mapData = mapData;

        ValidateMap();
    }

    public Tile GetTile(MapCoordinates coords)
    {
        int index = coords.GetIndex(m_mapData);
        return m_isMapValid && IsIndexValid(index) ? m_tileMap[index] : null;
    }

    public Tile GetTile(int index)
    {
        return IsIndexValid(index) ? m_tileMap[index] : null;
    }
    
    private bool IsIndexValid(int index)
    {
        return m_isMapValid && index >= 0 && index < m_mapData.GridWidth * m_mapData.GridHeight;
    }

    private void ValidateMap()
    {
        m_isMapValid = m_mapData != null && m_tileMap != null;

        // TODO: Check more things to validate the map. If nothing more can be validated, move this to the constructor and flag m_isMapValid as readonly
    }

    private readonly Tile[] m_tileMap = null;
    private readonly MapData m_mapData = null;

    private bool m_isMapValid = false;
}
