using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using XS_Utils;

public class NotificacionsProva : MonoBehaviour
{
    public InternalNotifications notifications;
    private void Update()
    {
        if (Key.A.OnPress())
        {
            notifications.Notify();
        }
    }

}
