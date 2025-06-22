using UnityEngine;
using UnityEngine.EventSystems;
using TMPro; 

public class onMouseButtonScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private TMP_Text textComponent;
    [SerializeField] private TMP_FontAsset offMouseFont;
    [SerializeField] private TMP_FontAsset onMouseFont;
    [SerializeField] private AudioSource onMouseSound;

    public AudioClip buttonSound;


    public void OnPointerEnter(PointerEventData eventData)
    {
        textComponent.font = onMouseFont;
        onMouseSound.clip = buttonSound;
        onMouseSound.Play();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        textComponent.font = offMouseFont;
    }
}
