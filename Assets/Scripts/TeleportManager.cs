using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class TeleportManager : MonoBehaviour
{
    public InputActionReference teleportActionReference;
    public UnityEvent onTeleportActive;
    public UnityEvent onTeleportCancel; // Corregido el error tipográfico

    void Start()
    {
        teleportActionReference.action.performed += teleportActive; // Corregido para usar el método correcto
        teleportActionReference.action.canceled += teleportCancel;
    }

    void DelayedTeleportCancel()
    {
        onTeleportCancel.Invoke(); // Corregido el error tipográfico
    }

    private void teleportCancel(InputAction.CallbackContext obj)
    {
        Invoke("DelayedTeleportCancel", 0.1f);
    }

    private void teleportActive(InputAction.CallbackContext obj)
    {
        onTeleportActive.Invoke();
    }
} // Asegúrate de que esta llave cierra la clase correctamente
