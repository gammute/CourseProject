using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    private FloarPos nowFloar = new FloarPos(0, 1, 0);

    private List<Vector3> allFloarPositions = new List<Vector3> 
    {
        new Vector3 (0, 1, 0)
    };

    private bool IsFloorPositionEmpty(Vector3 targetPos)
    {
        if (targetPos.y == 0)
        return false;

        foreach (Vector3 pos in allFloarPositions)
        {
            if (pos.y == targetPos.y)
            return false;
        }
        return true;
    }
}

struct FloarPos 
{
    public int x, y, z;

    public FloarPos(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Vector3 getVector()
    {
        return new Vector3(x, y, z);
    }

    public void setVector(Vector3 pos)
    {
        x = Convert.ToInt32(pos.x);
        y = Convert.ToInt32(pos.y);
        z = Convert.ToInt32(pos.z);
    }
}
