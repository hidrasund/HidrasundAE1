using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ForwardBackwardTranslation = Input.GetAxis("Vertical") * Speed;
        float LeftRightTranslation = Input.GetAxis("Horizontal") * Speed;

        transform.Translate(LeftRightTranslation, 0, ForwardBackwardTranslation);
    }
}