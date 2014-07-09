using UnityEngine;
using System.Collections;

public class Gerde : MonoBehaviour
{

    public tk2dTileMap Map;

    public int TileId;

    public 
	// Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
        TileId = Map.GetTileIdAtPosition(new Vector3(transform.position.x,transform.position.y,0f), 17);
	}
}
