using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hsc : MonoBehaviour
{
    float hl = 100;
    public Image hi;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            if (hl + 10 <= 100)
                hl += 10;
            else
                hl = 100;
            hi.transform.localScale = new Vector3(hl / 100, 1, 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            if (hl >= 5)
                hl -= 5;

            hi.transform.localScale = new Vector3(hl / 100, 1, 1);
        }
    }
}
