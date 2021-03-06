using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(menuName = "Xido Studio/Notifications")]
public class InternalNotifications : ScriptableObject
{
    [SerializeField] GameObject uiPrefab;

    [SerializeField] Sprite icone;
    [SerializeField] LocalizedString titol;
    [SerializeField] LocalizedString descripcio;

    [ContextMenu("Show")]
    public void Notify()
    {
        Instantiate(uiPrefab).GetComponent<InternalNotificationAspect>().Set(titol, descripcio, icone);
    }
}
