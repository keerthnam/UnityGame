using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    private Menus menus;

    // Start is called before the first frame update
    void Start()
    {
        menus = FindAnyObjectByType<Menus>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            menus.WinMenu();
        }
    }
}
