using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Localization;
using UnityEngine.ResourceManagement.AsyncOperations;

public class InternalNotificationAspect : MonoBehaviour
{
    [SerializeField] Image icone;
    [SerializeField] TMP_Text titol; 
    [SerializeField] TMP_Text descripcio;

    public void Set(Sprite icone, LocalizedString titol, LocalizedString descripcio)
    {
        this.icone.sprite = icone;
        titol.GetLocalizedStringAsync(titol).Completed += Titol;
        descripcio.GetLocalizedStringAsync(descripcio).Completed += Descripcio;
    }

    public void Set(LocalizedString titol, LocalizedString descripcio)
    {
        this.icone.enabled = false;
        titol.GetLocalizedStringAsync(titol).Completed += Titol;
        descripcio.GetLocalizedStringAsync(descripcio).Completed += Descripcio;

        this.titol.GetComponent<RectTransform>().anchoredPosition = new Vector2(20, 20);
        this.descripcio.GetComponent<RectTransform>().anchoredPosition = new Vector2(20, 20);
    }

    void Titol(AsyncOperationHandle<string> op) => titol.text = op.Result;
    void Descripcio(AsyncOperationHandle<string> op) => descripcio.text = op.Result;

}
