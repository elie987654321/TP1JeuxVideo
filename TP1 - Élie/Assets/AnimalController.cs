using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    [SerializeField]
    private float vitesse;

    [SerializeField]
    private float positionXMin;

    [SerializeField]
    private float positionXMax;

    [SerializeField]
    private float distanceTrajectoire;

    private float positionXDebutTrajectoire;

    private float positionXFinTrajectoire;

    private bool dirigeVersDroite;

    // Start is called before the first frame update
    void Start()
    {
        positionXDebutTrajectoire = Random.Range(positionXMin, positionXMax - distanceTrajectoire);
        positionXFinTrajectoire = positionXDebutTrajectoire + distanceTrajectoire;
        dirigeVersDroite = true;
        this.transform.position = new Vector3(positionXDebutTrajectoire, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (dirigeVersDroite)
        {
            transform.Translate(new Vector3(vitesse * Time.deltaTime, 0, 0));
            if (this.transform.position.x > positionXFinTrajectoire)
            {
                dirigeVersDroite = false;
            }
        }
        else
        {
            transform.Translate(new Vector3(-vitesse * Time.deltaTime, 0, 0));
            if (this.transform.position.x < positionXDebutTrajectoire)
            {
                dirigeVersDroite = true;
            }
        }
    }
}
