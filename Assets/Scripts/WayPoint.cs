using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    public Transform GetWayPoint(int wayPointIndex)
    {
        return transform.GetChild(wayPointIndex);
    }

    public int GetNextWavepointIndex(int currentIndex)
    {
        int nextWavePoint = currentIndex + 1;

        if (nextWavePoint == transform.childCount)
        {
            nextWavePoint = 0;
        }

        return nextWavePoint;
    }
}
