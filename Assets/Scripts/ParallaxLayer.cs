using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Allows the controller to move each layer based on the parallaxAmount!*/

public class ParallaxLayer : MonoBehaviour
{
    [Range(-1f, 1f)]
    public float parallaxAmount; //The amount of parallax! 1 simulates being close to the camera, -1 simulates being very far from the camera!
    [System.NonSerialized] public Vector3 newPosition;
    [SerializeField] public float scalar = 40f;
    [SerializeField] bool horizontalOnly = true;
    public void MoveLayer(float positionChangeX, float positionChangeY)
    {
        newPosition = transform.localPosition;
        if (horizontalOnly)
        {
            newPosition.x -= positionChangeX * (-parallaxAmount * scalar) * (Time.deltaTime);
        }
        else
        {
            newPosition.x -= positionChangeX * (-parallaxAmount * scalar) * (Time.deltaTime);
            newPosition.y -= positionChangeY * (-parallaxAmount * scalar) * (Time.deltaTime);
        }


        transform.localPosition = newPosition;
    }
}