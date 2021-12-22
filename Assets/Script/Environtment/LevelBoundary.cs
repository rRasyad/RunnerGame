using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -3.9f;//barrier left
    public static float rightSide = 3.9f;//barrier right
    public static float upSide = 1.8f;//barrier top
    //if we want to change the value can use the variables below
    public float internalLeft;
    public float internalRight;
    public float internalUp;


    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
        internalUp = upSide;
    }
}
