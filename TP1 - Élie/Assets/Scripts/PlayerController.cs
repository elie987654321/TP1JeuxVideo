using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float limiteMouvementInferieur;

    [SerializeField]
    private float limiteMouvementSuperieur;

    //Empeche que le joueur reste pris quand il atteint la limite de son amplitude de mouvement
    [SerializeField]
    private float distanceBuffer;

    [SerializeField]
    private GameObject projectilePrefab;

    [SerializeField]
    private float fireSpeed;

    private float timer;


    private void Start()
    {
        timer = fireSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        GererMouvement();
        GererProjectile();
    }

    private void GererMouvement() 
    {

        float positionX = transform.position.x;

        if (positionX < limiteMouvementInferieur)
        {
            transform.Translate(new Vector3(distanceBuffer * Time.deltaTime, 0, 0));
        }
        else if (positionX > limiteMouvementSuperieur)
        {
            transform.Translate(new Vector3(-distanceBuffer * Time.deltaTime, 0, 0));
        }
        else
        {
            float mouvementHorizontal = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
            transform.Translate(new Vector3(mouvementHorizontal, 0, 0)); 
        }
    }

    private void GererProjectile()
    {
        timer -= Time.deltaTime;

        if (timer < 0 && Input.GetAxis("Jump") != 0)
        {
            timer = fireSpeed;
            GameObject projectile = Instantiate(projectilePrefab);
            projectile.transform.position = this.transform.position;
        }
    }
}
