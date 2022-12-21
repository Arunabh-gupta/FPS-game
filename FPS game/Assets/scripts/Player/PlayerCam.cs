using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float mouseSensitivity = 100f;
    [SerializeField] private Transform playerBody;
    float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Look(playerBody.up);
    }

    void Look(Vector3 RotationAxis){
        float mousex = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mousey;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(RotationAxis * mousex);

    }
}
