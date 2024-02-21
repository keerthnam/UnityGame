using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace maze
{
    public class Spikeball : MonoBehaviour
    {
        // Class variables
        [SerializeField] private float _forceAmount = 10.0f;
        private Rigidbody2D _rb; // Reference type - References the class rigidbody.

        // Start is called before the first frame update
        void Start()
        {
            _rb = GetComponent<Rigidbody2D>(); // Filling the empty _rb with the component attached to the object, Marked by the type defined. 
            ApplyForce(); // Calling the method or invoking it.
        }

        private void ApplyForce() // Example of a private Method.
        {
            Vector2 force = new Vector2(_forceAmount, 0); // This an example of a Local variable, that only exists in the method.
            _rb.AddForce(force, ForceMode2D.Impulse); // Burst of force.
        }
    }
}
