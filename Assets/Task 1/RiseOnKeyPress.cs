using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// In this code, the programmer has made input checks for both arrow keys and the WS keys.
/// Please modify the code to use Unity's Input Axis system instead.
/// 
/// Extra credit: Make a new function that takes in a parameter to move the cube, and call that function in Update() based on the inputs made.
/// 
/// Exta credit 2: Allow for Left/right inputs too.
/// </summary>

public class RiseOnKeyPress : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.up * Input.GetAxis("Vertical") * 0.1f);
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * 0.1f);
    }
}
