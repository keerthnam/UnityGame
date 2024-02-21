using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaPuddle : MonoBehaviour
{
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    // One of the two objects in the collision must have a rigid body.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.ResetPlayer();
        }
        else if(collision.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
        }
    }

}
