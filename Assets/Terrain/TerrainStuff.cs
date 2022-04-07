using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainStuff : MonoBehaviour
{
    float num1 = 10;
    float num2 = 5;


    // Start is called before the first frame update
    void Start()
    {
        float num0 = Random.Range(num1, num2 * 10);
        Debug.Log(num0);

        num0 = Mathf.Sqrt(num0);
        num0 = Mathf.Round(num0);
        Debug.Log(num0);

    }

    // Update is called once per frame
    void Update()
    {
        ///Debug Message, if sphere above 5 or below 0 or between
        if (transform.position.y >= 5)
        {
            Debug.Log("High Altitude");
        }
        else if (transform.position.y < 5 && transform.position.y >= 0)
        {
            Debug.Log("Water Lvl");
        }
        else
        {
            Debug.Log("Buried...or drowning");
        }
        Debug.Log(NegativeY());

    }

    bool NegativeY()
    {
        if (transform.position.y < 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
