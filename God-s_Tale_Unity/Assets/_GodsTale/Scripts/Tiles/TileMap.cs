using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;

[CreateAssetMenu(fileName = "TileMap", menuName = "God's_Tale/Map/TileMap")]
public class TileMap : ScriptableObject
{
    public Dictionary<StringConstant, TileData> Tiles { get { return m_tilesDic; } }

    //TMP: Until implement serializable dictionary
    public void InitTileMap()
    {
        m_tilesDic = new Dictionary<StringConstant, TileData>();

        foreach(TileData tileData in m_tiles)
        {
            m_tilesDic[tileData.ID] = tileData;
        }
        
    }
    
    [SerializeField] private TileData[] m_tiles = null; // TODO: A tilemap should be something more complex than a single tiledata and should be able to expand this. For now  and testing is something
                                                        // Actually this need to be a serializable dictionary

    //TMP: Until implement serializable dictionary
    private Dictionary<StringConstant, TileData> m_tilesDic = null;
}
