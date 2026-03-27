using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);

        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log(Keyboard.current.wKey.isPressed);
            inputVector.y = 1f;
        }

        if (Keyboard.current.sKey.isPressed)
        {
            inputVector.y = -1f;
        }


        if (Keyboard.current.aKey.isPressed)
        {
            inputVector.x = -1f;
        }


        if (Keyboard.current.dKey.isPressed)
        {
            inputVector.x = 1f;
        }

        Debug.Log(inputVector);

    }
}