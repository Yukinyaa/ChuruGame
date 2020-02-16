using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Move());
    }
    private void Update()
    {

    }

    IEnumerator Move()
    {
        for ( ; ; )
        {
            // for (float i = 0; i < 15; i += Time.deltaTime)
            // {
            //     transform.position -= new Vector3(Time.deltaTime * speed, 0, 0);
            //     yield return null;
            // }
            // for (float i = 0; i < 10; i += Time.deltaTime)
            // {
            //     transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
            //     yield return null;
            // }
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;

            yield return new WaitForSeconds(Random.Range(0.5f,3));

            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<BoxCollider2D>().enabled = true;

            yield return new WaitForSeconds(Random.Range(0.5f,3));

        }
    }
}
