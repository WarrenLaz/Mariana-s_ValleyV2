using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float fireR = 0.2f;
    public Transform firingPoint;
    public GameObject Bullet;
   //public Firepointscript fire;


    float timeUntilFire;
    PlayerScript pm;

    private void Start()
    {
        pm = gameObject.GetComponent<PlayerScript>();
        //fire = gameObject.GetComponent<Firepointscript>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && timeUntilFire < Time.time)
        {
            Fire();
            timeUntilFire = Time.time + fireR;
        }
    }

    void Fire()
    {
        float angle = pm.IsFacingRight ? 0f : 180f;
        Instantiate(Bullet, firingPoint.position, Firepointscript.rota);
    }
}
