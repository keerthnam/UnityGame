using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslationController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5.0f;
    [SerializeField] private float floatNum = 5.0f;

    // Update is called once per frame
    void Update()
    {
        PlayerTranslation();
        Debug.Log(FloatReturnType()); // This would return 4.4f every line
    }

    /// <summary>
    /// Gets input from the controller, and applies a translation to the player character.
    /// </summary>
    private void PlayerTranslation()
    {
        // Get Input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 moveDirection = new Vector2(horizontalInput, verticalInput);
        transform.Translate(moveDirection * _moveSpeed * Time.deltaTime);
    }

    // Code below is example only.

    private float FloatReturnType()
    {
        float placeholderFloat = 4.4f;
        return placeholderFloat;
    }

    private bool BoolReturnType()
    {
        bool placeholderBool = false;
        return placeholderBool;
    }

    private bool IfExample()
    {
        // Is 5 greater then 6
        if (floatNum > 6)
        {
            IfBlock();
            return true;
            // is 5 equal to 6
        }else if ( floatNum != 6 && floatNum <= 5)
        {
            ElseIfBlock();
            return true;
        }
        else
        {
            ElseBlock();
            return false;
        }
    }

    private void IfBlock()
    {

    }

    private void ElseBlock()
    {

    }

    private void ElseIfBlock()
    {

    }

}
