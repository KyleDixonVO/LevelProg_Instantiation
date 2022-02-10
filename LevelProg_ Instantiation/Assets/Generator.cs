using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject GamerCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GamerCube.transform.position = new Vector3(1, 2, 0);
        GamerCube.AddComponent<Rigidbody>();
        GamerCube.GetComponent<Renderer>().material.SetColor("_GamerCube", Color.cyan);

        GameObject RoundBoy = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        RoundBoy.transform.position = new Vector3(-1, 1, 0);
        RoundBoy.AddComponent<Rigidbody>();
    }
}
