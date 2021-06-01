using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBricks : MonoBehaviour
{
    const int brickZSize = 2;
    const int brickXSize = 5;
    float xPos = 3f;
    float zPos = 98.5f;
    [SerializeField] GameObject brick;
    [SerializeField] int columns;
    [SerializeField] int rows;
    void Start()
    {
        Generate();
    }

    void Update()
    {
        
    }

    void Generate(){
        for(int i = 0; i < rows; i++){
            for(int j = 0; j < columns; j++){
                Instantiate(brick, new Vector3(xPos, 0f, zPos), Quaternion.identity, transform);
                xPos += brickXSize;
            }
            zPos -= brickZSize;
            xPos = 3f;
        }
    }
}
