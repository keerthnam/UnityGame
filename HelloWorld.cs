using maze;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Bools are defaulted to false.
    private bool _trueFalse = true; // This is hidden in the inspector. As it is closed to the class only.
    [SerializeField] private bool _visableTrueFalse; //Visable in the inspector, BUT its still closed to the class only.
    public bool openTrueFalse; // This bool is open to all scripts, and can be accessed and changed. Only do this when needed.

    // declaring data types
    [SerializeField] private bool _bool;
    [SerializeField] private int _emptyContainer;
    [SerializeField] private int _wholeNumber = 10;
    [SerializeField] private float _decimalNumber = 5.5f; // floats all have an f at the end. This makes the floats calculations work.
    [SerializeField] private string _text = "Happy Brithday!";


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
        Debug.Log(_wholeNumber);
        Debug.Log(_wholeNumber * _wholeNumber);
        Debug.Log(_wholeNumber + _decimalNumber);
        Debug.Log(_wholeNumber / _decimalNumber);
        Debug.Log(_decimalNumber);
        Debug.Log(_text);
        Debug.Log(_trueFalse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
