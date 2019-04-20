using UnityEngine;

public class MapUtilities
{
    public static void WorldToMap(float worldX, float worldZ, out int x, out int y, in MapData mapData)
    {
        float pX = worldX / mapData.WorldWidth;
        float pY = worldZ / mapData.WorldHeight;

        x = (int)(pX * mapData.GridWidth);
        y = (int)(pY * mapData.GridHeight);
    }

    public static void WorldToMap(Vector3 coords, out int x, out int y, in MapData mapData)
    {
        WorldToMap(coords.x, coords.z, out x, out y, in mapData);
    }

    public static MapCoordinates WorldToMap(float worldX, float worldZ, in MapData mapData, float h = 0.0f)
    {
        WorldToMap(worldX, worldZ, out int x, out int y, mapData);
        return new MapCoordinates(x, y, h);
    }

    public static MapCoordinates WorldToMap(Vector3 coords, in MapData mapData, float h = 0.0f)
    {
        WorldToMap(coords, out int x, out int y, mapData);
        return new MapCoordinates(x, y, h);
    }

    public static void MapToWorld(int x, int y, out Vector3 coordinates, in MapData mapData)
    {
        coordinates = new Vector3(  x + (x * mapData.TileOffset) + (mapData.TileOffset / 2) + (mapData.TileWidth / 2),
                                    0.0f,
                                    y * (y * mapData.TileOffset) + (mapData.TileOffset / 2) + (mapData.TileHeight / 2));
    }

    public static Vector3 MapToWorld(MapCoordinates coords, in MapData mapData)
    {
        MapToWorld(coords.X, coords.Y, out Vector3 ret, mapData);
        return ret;
    }
}
