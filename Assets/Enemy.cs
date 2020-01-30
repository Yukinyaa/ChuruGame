using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 1;

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
            for (float i = 0; i < 2; i += Time.deltaTime)
            {
                transform.position -= new Vector3(Time.deltaTime * speed, 0, 0);
                yield return null;
            }
            for (float i = 0; i < 2; i += Time.deltaTime)
            {
                transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
                yield return null;
            }
        }
    }
}
