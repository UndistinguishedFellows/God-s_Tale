using UnityEngine;

[CreateAssetMenu(fileName = "MapCoordinates", menuName = "God's_Tale/Map/MapCoordinates")]
public class MapCoordinates : ScriptableObject
{
    public int X { get; set; }
    public int Y { get; set; }
    public float Height { get; set; } = 0.0f;
    
    public MapCoordinates()
    {

    }

    public MapCoordinates(int x, int y, float h = 0.0f)
    {
        X = x;
        Y = y;
        Height = h;
    }
    
    public static MapCoordinates FromWorld(Vector3 position, in MapData mapData, float h = 0.0f)
    {
        return MapUtilities.WorldToMap(position, in mapData, h);
    }
    
    public static MapCoordinates FromWorld(float x, float z, in MapData mapData, float h = 0.0f)
    {
        return MapUtilities.WorldToMap(x, z, in mapData, h);
    }

    public static MapCoordinates FromIndex(int index, in MapData mapData)
    {
        return new MapCoordinates(index % mapData.GridWidth, index / mapData.GridWidth);
    }

    public int GetIndex(in MapData mapData)
    {
        return X + Y * mapData.GridWidth;
    }

    public MapCoordinates SetWidthIndex(int index, in MapData mapData)
    {
        X = index % mapData.GridWidth;
        Y = index / mapData.GridWidth;

        return this;
    }

    public Vector3 ToWorldCoordinates(in MapData mapData)
    {
        return MapUtilities.MapToWorld(this, in mapData);
    }
}
