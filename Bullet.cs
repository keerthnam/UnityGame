using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float waitTime = 5f;
    [SerializeField] private GameObject particleEffect;
     private AudioSource audioSource;

    void Start()
    {
        StartCoroutine(TimeToLive());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var effect = Instantiate(particleEffect, transform.position, Quaternion.identity);
        if (collision.gameObject.CompareTag("Breakable"))
        {
            effect.GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }

    IEnumerator TimeToLive()
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject); // Destory self.
    }

}
