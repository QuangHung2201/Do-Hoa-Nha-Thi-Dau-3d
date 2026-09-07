
using UnityEngine;
using UnityEngine.InputSystem;

public class Mouselook : MonoBehaviour
{
    public static Mouselook Instance;
    [SerializeField] private float mousesensitivity;

    [SerializeField] private Transform tranformcamera;

    float xrotation = 0;

    private void Start()
    {
        Instance = this;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        rotationPlayer();
    }
    public void rotationPlayer()
    {
        Vector2 mouse = Mouse.current.delta.ReadValue();

        float xmouse = mouse.x * mousesensitivity * Time.deltaTime; // trai phai
        float ymouse = mouse.y * mousesensitivity * Time.deltaTime; // trenduoi

        transform.Rotate(Vector3.up * xmouse);

        //lenxg
        xrotation -= ymouse; //xoay y theo trục x ( ngược )
        xrotation = Mathf.Clamp(xrotation, -30, 60);

        tranformcamera.localRotation = Quaternion.Euler(xrotation,0,0);
    }    

}
