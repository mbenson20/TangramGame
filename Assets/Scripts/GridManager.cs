using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GridManager : MonoBehaviour
{
    //public GameObject referenceTile;

    [SerializeField]
    private int rows = 5;
    [SerializeField]
    private int columns = 8;
    [SerializeField]
    private float tileSize = 240;


    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        GameObject referenceTile = (GameObject)Instantiate(Resources.Load("GridTile"));
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                GameObject tile = (GameObject)Instantiate(referenceTile, transform);

                float posX = column * tileSize;
                float posY = row * tileSize;

                tile.transform.position = new Vector2(posX, posY);
            }
        }

        Destroy(referenceTile);

        float gridW = columns * tileSize;
        float gridH = rows * tileSize;
        transform.position = new Vector2(gridW / 2 + tileSize / 2, gridH / 2 + tileSize / 2);
    }


}
