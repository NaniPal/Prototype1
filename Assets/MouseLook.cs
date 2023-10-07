using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 2.0f; // Mouse sensitivity.
    public float minYRotation = -90.0f; // Minimum vertical rotation angle.
    public float maxYRotation = 90.0f; // Maximum vertical rotation angle.

    private float rotationX = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");


        rotationX -= mouseY * sensitivity;
        rotationX = Mathf.Clamp(rotationX, minYRotation, maxYRotation);


        transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        transform.parent.rotation *= Quaternion.Euler(0, mouseX * sensitivity, 0); 
    }
}
