using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorCollider : MonoBehaviour
{
    public GameObject text;


    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Enemy")
            StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        text.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        text.SetActive(false);
    }
}
