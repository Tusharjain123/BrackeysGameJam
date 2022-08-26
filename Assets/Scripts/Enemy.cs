using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private WayPoint wayPointPath;

    [SerializeField] private float speed;
    private int targetIndex;

    private Transform previousWaypoint;
    private Transform targetWaypoint;


    private float timeToWaypoint;
    private float elapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        TargetNextWayPoint();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        elapsedTime += Time.deltaTime;
        float elapsedPercent = elapsedTime / timeToWaypoint;
        elapsedPercent = Mathf.SmoothStep(0, 1, elapsedPercent);

        transform.position = Vector2.Lerp(previousWaypoint.position, targetWaypoint.position, elapsedPercent);
        //transform.rotation = Quaternion.Lerp(previousWaypoint.rotation, targetWaypoint.rotation, elapsedPercent);

        if (elapsedPercent >= 1)
        {
            TargetNextWayPoint();
        }
    }

    private void TargetNextWayPoint()
    {
        previousWaypoint = wayPointPath.GetWayPoint(targetIndex);
        targetIndex = wayPointPath.GetNextWavepointIndex(targetIndex);

        targetWaypoint = wayPointPath.GetWayPoint(targetIndex);

        elapsedTime = 0;
        float dstToWaypoint = Vector2.Distance(previousWaypoint.position, targetWaypoint.position);

        timeToWaypoint = dstToWaypoint / speed;
    }
}
