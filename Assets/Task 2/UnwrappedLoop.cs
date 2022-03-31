using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This script currently spawns 10 spheres in a stack when the game is first played
/// Please rewrite it using a Loop.
/// 
/// Extra credit: Make the number of spheres a variable for the editor.
/// 
/// Extra credit 2: Make it so every time the spacebar is pressed, another N spheres appear on top.
/// </summary>

public class UnwrappedLoop : MonoBehaviour
{

    public GameObject sphere;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
        Instantiate(sphere, new Vector3(0, i, 0), Quaternion.identity);
        }


    }


    void Update()
    {
        
    }
}
