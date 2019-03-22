using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{

    //Properites for controlling the noise
    [Range(0,100)]
    public float scale = 1.0f;

    [Range(0,12)]
    public int octaves = 1;

    [Range(0,1)]
    public float persistance = 1f;
    [Min(1)]
    public float lacunarity = 1f;

    public float offsetX = 0f;
    public float offsetY = 0f;


    public float[,] CreateHeightMap(int sizeX, int sizeY, float offsetXValue, float offsetYValue)
    {
        float[,] heightMap = new float[sizeX, sizeY]; //Init height map with size

        for (int i = 0; i < sizeX; i++)
        {
            for (int j = 0; j < sizeY; j++)
            {
                float amplitude = 1; //Always 1
                float frequency = 1; //Always 1
                float noiseHeight = 0;

                for (int k = 0; k < octaves; k++) //Loop through octaves
                {
                    var x = (offsetXValue + i) / scale * frequency; //Get non whole numbers for different noise (Whole numbers in unity return the same value)
                    var y = (offsetYValue + j) / scale * frequency;

                    float noise = Mathf.PerlinNoise(x, y); //Get height 

                    noiseHeight += noise * amplitude; //Add for each octaves
                     
                    amplitude *= persistance; //How much amplitude carries over to the next octave
                    frequency *= lacunarity; //How much frequency carries over to the next octave
                }

                heightMap[i, j] = noiseHeight; //Set noise height
            }
        }

        return heightMap;
    }

    private void OnDrawGizmos()
    {
        Debug.Log("Hello");
        int mapSize = 64;
        for (int x = 0; x < 4; x++) //Chunk X
        {
            for (int y = 0; y < 4; y++) //Chunk Y
            {
                float[,] map = CreateHeightMap(mapSize, mapSize, offsetX + (x * mapSize), offsetY + (y * mapSize)); //Get Height map
                for (int i = 0; i < map.GetLength(0); i++) 
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Gizmos.DrawCube(new Vector3(i + (x * mapSize), (map[i, j] * 25) + 100, j + (y * mapSize)), Vector3.one); //Render Heightmap
                    }
                }
            }
        }
        
    }
}
