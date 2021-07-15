using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handyrock : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(true);
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            gameObject.SetActive(false);
        }
    }
}
