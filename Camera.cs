using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject ball;
    public Vector3 offfset;
    // Start is called before the first frame update
    void Start()
    {
        offfset = new Vector3(15, 5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.transform.position + offfset;
    }
}
