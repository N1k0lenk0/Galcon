using UnityEngine;
using UnityEngine.EventSystems;
using TMPro; 

public class ButtonFontChanger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TMP_Text textComponent; 
    public TMP_FontAsset offMouseFont;
    public TMP_FontAsset onMouseFont;

    public void OnPointerEnter(PointerEventData eventData)
    {
        textComponent.font = onMouseFont;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        textComponent.font = offMouseFont;
    }
}
