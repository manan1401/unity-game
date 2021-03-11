using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capusle_color_change : MonoBehaviour
{
    Color[] colors = new Color[4];
    // Start is called before the first frame update
    void Start()
    {
        colors[0] = Color.red;
        colors[1] = Color.blue;
        colors[2] = Color.green;
        colors[3] = Color.yellow;

        GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];

    }

    // Update is called once per frame
    void Update()
    {

    }
}
