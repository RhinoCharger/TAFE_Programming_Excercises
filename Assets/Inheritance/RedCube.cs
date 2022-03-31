using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCube : Interitance
{

    public float height = 1;

    protected override void MoveUp()
    {
        transform.Translate(Vector3.up);
        transform.Rotate(transform.up, 50);
    }
}
