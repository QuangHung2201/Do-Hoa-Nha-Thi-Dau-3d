using UnityEngine;
using UnityEngine.InputSystem;

public class Playermovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private CharacterController m_charac;

    void Start()
    {
        m_charac = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector2 input = Vector2.zero;
        if (Keyboard.current.wKey.isPressed) input.y = 1;
        if (Keyboard.current.sKey.isPressed) input.y = -1;
        if (Keyboard.current.aKey.isPressed) input.x = -1;
        if (Keyboard.current.dKey.isPressed) input.x = 1;


        Vector3 move = transform.forward * input.y 
            + transform.right * input.x;

        m_charac.Move(move * speed * Time.deltaTime);

        //Mouselook.Instance.rotationPlayer();
    }
}
