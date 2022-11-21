using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMovement : MonoBehaviour
{
    [SerializeField] Transform centerRotation;
    [SerializeField] float radiusRotation = 1f, angularSpeed = 3f;
    float posX, posZ,posY, angle = 0f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        posX =  centerRotation.position.x + Mathf.Cos (angle) * radiusRotation;
        posY =  centerRotation.position.y + Mathf.Sin (angle) * radiusRotation;
        posZ =  centerRotation.position.z + Mathf.Sin (angle) * radiusRotation;
        angle += Time.deltaTime * angularSpeed;
        if (angle >= 360f)
            angle = 0f;

        transform.position = new Vector3(posX,posY,posZ);
    }
}