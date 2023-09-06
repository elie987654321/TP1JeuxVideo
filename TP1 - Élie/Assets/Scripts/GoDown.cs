using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDown : MonoBehaviour
{
    [SerializeField]
    private float speed;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(0,0, -speed * Time.deltaTime));
    }
}
