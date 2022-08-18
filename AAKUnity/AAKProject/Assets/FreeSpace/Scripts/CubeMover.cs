using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var framespeed = Time.deltaTime * speed;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0, 0, framespeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0, 0, -framespeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-framespeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(framespeed, 0, 0);
        }
    }
}
