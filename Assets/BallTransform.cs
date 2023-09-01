using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    Renderer ren;
    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<Renderer>();
        ren.material.color = Color.black; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(0.005f, 0.005f, 0.005f);
        transform.Rotate(new Vector3(0.5f, 0, 0)); 
    }
}
