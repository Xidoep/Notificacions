using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Unity.Notifications.Android;

public class Notificacions : MonoBehaviour
{
    const string ID = "default_channel";
    const string NAME = "Default Channel";
    const string DESCRIPTION = "For Generic notifications";



    #region Intance
    public static Notificacions Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion

   // AndroidNotification notificacio;

    private void Start()
    {
        RegistrarCanal();
    }

    void RegistrarCanal()
    {
        /*AndroidNotificationChannel _canalNotificacioGenerica = new AndroidNotificationChannel()
        {
            Id = ID,
            Name = NAME,
            Description = DESCRIPTION,
            Importance = Importance.Default,
        };

        AndroidNotificationCenter.RegisterNotificationChannel(_canalNotificacioGenerica);*/

    }
    void Notificacio()
    {
       
    }

}
