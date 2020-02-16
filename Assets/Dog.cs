using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum DogState
{
    Stay, Follow
}
public class Dog : MonoBehaviour
{

    public Transform player;
    public DogState state = DogState.Stay;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(state == DogState.Follow)
        {
            var vector = player.position - transform.position;
            transform.position += vector.normalized*Time.deltaTime*0.6f;
        }
    }
}
