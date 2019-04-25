using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;
using System.Linq;

public class MapGenerator : MonoBehaviour
{
    [ContextMenu("Generate random map")]
    public void GenerateRandomMap()
    {
        m_tileMap.InitTileMap(); // TMP
        m_mapData.CalcMapSize();
        
        StringConstant[] tilesIds = new StringConstant[m_mapData.GridCount];
        for(int i = 0; i < m_mapData.GridCount; ++i)
        {
            StringConstant key = m_tileMap.Tiles.Keys.ToArray()[Random.Range(0, m_tileMap.Tiles.Keys.Count)];
            tilesIds[i] = m_tileMap.Tiles[key].ID;
        }

        m_map = new Map(in tilesIds, in m_mapData);
    }

    [SerializeField] private MapData m_mapData = null;
    [SerializeField] private TileMap m_tileMap = null;

    private Map m_map = null;
}
