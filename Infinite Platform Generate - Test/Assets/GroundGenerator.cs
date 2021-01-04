using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    float lastPosition = 0;
    Vector3 nextPos;
    public GameObject prefab_red, prefab_green;

    bool green;
    void generatePlatform()
    {
        lastPosition = lastPosition + (10 / 2) + (10 / 2);
        nextPos = new Vector3(0, 0, lastPosition);
        if (green)
        {
            Instantiate(prefab_green, nextPos, Quaternion.identity);
            green = false;
        }
        else
        {
            Instantiate(prefab_red, nextPos, Quaternion.identity);
            green = true;
        }

    }
    void Start()
    {
        generatePlatform();
    }

    void Update()
    {
        if (lastPosition < Camera.main.transform.position.z + 20)
            generatePlatform();
        Camera.main.transform.Translate(Vector3.up * 5 * Time.deltaTime);
    }
}
