using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class TeleportManager : MonoBehaviour
{
    public InputActionReference teleportActionReference;
    public UnityEvent onTeleportActive;
    public UnityEvent onTeleportCancel; // Corregido el error tipogr�fico

    void Start()
    {
        teleportActionReference.action.performed += teleportActive; // Corregido para usar el m�todo correcto
        teleportActionReference.action.canceled += teleportCancel;
    }

    void DelayedTeleportCancel()
    {
        onTeleportCancel.Invoke(); // Corregido el error tipogr�fico
    }

    private void teleportCancel(InputAction.CallbackContext obj)
    {
        Invoke("DelayedTeleportCancel", 0.1f);
    }

    private void teleportActive(InputAction.CallbackContext obj)
    {
        onTeleportActive.Invoke();
    }
} // Aseg�rate de que esta llave cierra la clase correctamente
