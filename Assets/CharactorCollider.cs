using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorCollider : MonoBehaviour
{
    public GameObject text;
    public Dog dog;

    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Enemy>() != null)
           dog.state = DogState.Follow;
            
    }

    IEnumerator ShowText()
    {
        text.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        text.SetActive(false);
    }
}
