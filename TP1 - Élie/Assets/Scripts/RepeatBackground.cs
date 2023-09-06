using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private BoxCollider collider;

    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < startPosition.z - ((collider.size.z) * 5))
        {
            transform.position = startPosition;
        }
    }
}
