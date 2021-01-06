using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sc : MonoBehaviour
{
    public Button b;
    // Start is called before the first frame update
    void Start()
    {
        b.onClick.AddListener(msg);
    }

    void msg()
    {
        Debug.Log("your code here");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
