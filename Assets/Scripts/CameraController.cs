using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float boundX = 0.15f;
    public float boundY = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (GameManager.instance.playerDied)
        {
            target = null;
        }

        if(target != null)
        {

            MoveCamera();
        }
        


    }
    private void MoveCamera()
    {
        Vector3 delta = Vector3.zero;

        float deltaX = target.position.x - transform.position.x;
        float deltaY = target.position.y - transform.position.y;
        if (deltaX > boundX || deltaX < -boundX)
        {
            if (target.position.x - transform.position.x > 0)
            {
                delta.x = deltaX - boundX;
            }
            else
            {
                delta.x = deltaX + boundX;
            }
        }

        if (deltaY > boundY || deltaY < -boundY)
        {
            if (target.position.y - transform.position.y > 0)
            {
                delta.y = deltaY - boundY;
            }
            else
            {
                delta.y = deltaY + boundY;
            }
        }

        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}
