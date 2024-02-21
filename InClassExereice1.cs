using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InClassExereice1 : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // When the player presses the space button. Have them create a new object at run time.
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
    }
}
