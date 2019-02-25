using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    [SerializeField]
    private float SpeedFactor = 1f;

    void Start()
    {
    }

    
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        float So = transform.position.x;
        float S = So + horizontalInput * SpeedFactor * Time.deltaTime;
        transform.position = new Vector3(S, transform.position.y, transform.position.z);
    }
}
