using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float maxZPosition;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

        if (transform.position.z > maxZPosition)
        {
            Destroy(gameObject);
        }
    }
}
