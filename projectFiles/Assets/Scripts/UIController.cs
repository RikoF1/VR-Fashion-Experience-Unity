using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UIController : MonoBehaviour
{

    [SerializeField] private InputActionReference toggleUI;

    private bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {
        toggleUI.action.performed += ToggleUI;
        this.gameObject.SetActive(false);
    }

    private void ToggleUI(InputAction.CallbackContext context)
    {
        if (!isActive)
        {
            this.gameObject.SetActive(true);
            isActive = true;
        }
        else
        {
            this.gameObject.SetActive(false);
            isActive = false;
        }
    }
}
