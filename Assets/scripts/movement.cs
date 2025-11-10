using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class movement : MonoBehaviour
{
    [SerializeField] 
    InputAction right = new InputAction( type : InputActionType.Button);
    
    [SerializeField] 
    InputAction left = new InputAction( type : InputActionType.Button);
    
    [SerializeField] 
    InputAction down = new InputAction( type : InputActionType.Button);
    
    [SerializeField] 
    InputAction up = new InputAction( type : InputActionType.Button);
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (right.WasPressedThisFrame())
        {
            transform.position += new Vector3(1, 0, 0);
        }
        if (left.WasPressedThisFrame())
        {
            transform.position += new Vector3(-1, 0, 0);
        }

        if (down.WasPressedThisFrame())
        {
            transform.position += new Vector3(0, -1, 0);
        }
        if (up.WasPressedThisFrame())
        {
            transform.position += new Vector3(0, 1, 0);
        }
    }

    private void OnEnable()
    {
        right.Enable();
        left.Enable();
        down.Enable();
        up.Enable();
    }

    void OnDisable()
    {
        right.Disable();
        left.Disable();
        down.Disable();
        up.Disable();
    }
}
