using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Node 
    // a pure C# class (does not inherit from anything), can't add it as a game object in Unity
{
    public Vector2Int coordinates;
    public bool isWalkable;
    public bool isExplored;
    public bool isPath;
    public Node connectedTo;

    public Node(Vector2Int coordinates, bool isWalkable)
        // a constructor for our class
    {
        this.coordinates = coordinates;
        this.isWalkable = isWalkable;
    }
}
