using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public GameObject explosion;
    public static int score = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        var expFx = Instantiate(explosion, transform.position, transform.rotation);
        Destroy(expFx, 5);
        Destroy(gameObject);

        if (collision.gameObject.tag == "cube1")
        {
            score += 10;
        }
    }



}

