using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{

    public int numTiles;
    public int numTilesLeft;
    public GameObject tile;

    // Start is called before the first frame update
    void Start()
    {
        numTilesLeft = numTiles;
    }

    // Update is called once per frame
    void Update()
    {
        if (tile.GetComponent<BoxCollider2D>().IsTouching(gameObject.GetComponent<PolygonCollider2D>()))
        {
            numTilesLeft--;
        }
    }
}
