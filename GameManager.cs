using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public int keyAmount;
    [SerializeField] private int lives = 5;
    [SerializeField] private GameObject Player;
    public Transform PlayerSpawn;

    [SerializeField] private TMP_Text livesText;
    [SerializeField] private TMP_Text keysText;
    private Menus menus;
    private AudioSource audioSource;

    private void Start()
    {
        //Init objects.
        audioSource= GetComponent<AudioSource>();
        menus = GetComponent<Menus>();
        livesText.text = lives.ToString();
        keysText.text = keyAmount.ToString();
    }

    public void UpdateKey(int keysAdded)
    {
        keyAmount += keysAdded;
        keysText.text = keyAmount.ToString();
    }

    public void ResetPlayer()
    {
        audioSource.Play();
        lives--; // substacts 1 from the value
        livesText.text = lives.ToString();
        Player.transform.position = PlayerSpawn.position;
        if (lives <= 0)
        {
            Debug.Log("GameOver");
            menus.GameOver();
        }
    }
}
