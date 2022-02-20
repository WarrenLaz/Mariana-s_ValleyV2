using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firepointscript : MonoBehaviour
{
    PlayerScript ps;

    float mx;
    bool right;
    bool left;
    public GameObject myPlayer;
    public static Quaternion rota;
    private void Start()
    {

        ps = gameObject.GetComponent<PlayerScript>();
        mx = Input.GetAxis("Horizontal");
        right = true;
        left = false;
    }

    private void FixedUpdate()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        difference.Normalize();

        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
        rota = transform.rotation;


        if (Input.GetKeyDown(KeyCode.A))
        {
            left = true;
            right = false;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            right = true;
            left = false;
        }
        
        if (left == true)
        {
            /*
            if (rotationZ > -100)
            {
                transform.rotation = Quaternion.Euler(0f, 0f, -100f);
                rota = transform.rotation;
            }
            if (rotationZ < 100)
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 100f);
                rota = transform.rotation;
            }
            else
            {
               transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
                 rota = transform.rotation;
            }
            */
        }
        else if (right == true)
        {
            if (rotationZ > 80)
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 80f);
                rota = transform.rotation;
            }
            if (rotationZ < -80)
            {
                transform.rotation = Quaternion.Euler(0f, 0f, -80f);
                rota = transform.rotation;
            }
        }
        


    }

}