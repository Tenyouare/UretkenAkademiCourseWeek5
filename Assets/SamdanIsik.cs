using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamdanIsik : MonoBehaviour
{
    public GameObject samdan;
    // Start is called before the first frame update
    void Start()
    {
        samdan.GetComponent<Light>().intensity = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GetComponent<Light>().intensity = 1.5f;
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            samdan.GetComponent<Light>().intensity = 0f;
        }
    }
}
