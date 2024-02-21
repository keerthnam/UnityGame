using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] private GameObject droppedAudio;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && gameManager.keyAmount >= 1)
        {
            gameManager.UpdateKey(-1);
            Instantiate(droppedAudio, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
