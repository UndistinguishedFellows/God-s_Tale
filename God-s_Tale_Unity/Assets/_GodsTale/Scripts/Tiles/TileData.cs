using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;

[CreateAssetMenu(fileName = "TileData", menuName = "God's_Tale/Map/TileData")]
public class TileData : ScriptableObject
{
    public string ID { get { return m_tileIdentifier.Value; } }
    public Sprite Image { get { return m_image; } }
    public GameObject TilePrefab { get { return m_tilePrefab.Value; } }

    [SerializeField] private StringConstant m_tileIdentifier = null;
    [SerializeField] private Sprite m_image = null;
    [SerializeField] private GameObjectConstant m_tilePrefab = null;
}
