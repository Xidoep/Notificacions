using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Xido Studio/Notifications NoTranslate")]
public class InternalNotifications_NoTranslation : ScriptableObject
{
    [SerializeField] GameObject uiPrefab;

    [SerializeField] Sprite icone;
    [SerializeField] string titol;
    [SerializeField] string descripcio;

    [ContextMenu("Show")]
    public void Notify()
    {
        Instantiate(uiPrefab).GetComponent<InternalNotificationAspect>().Set(titol, descripcio, icone);
    }

}
