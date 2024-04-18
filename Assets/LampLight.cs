using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampLight : MonoBehaviour
{
    public GameObject lamba;
    // Start is called before the first frame update
    void Start()
    {
        lamba.GetComponent<Light>().intensity = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Light>().intensity = 0;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            lamba.GetComponent<Light>().intensity = 1.5f;
        }
    }
}
