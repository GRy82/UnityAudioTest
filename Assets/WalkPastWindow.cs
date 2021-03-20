using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkPastWindow : MonoBehaviour
{
    public Vector3 walkingSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localPosition += walkingSpeed;
    }
}
