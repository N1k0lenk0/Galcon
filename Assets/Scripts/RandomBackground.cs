using UnityEngine;
using UnityEngine.UI;

public class RandomBackgroundUI : MonoBehaviour
{
    public Image backgroundImage; // Сюди перетягуємо Image (UI)
    private Sprite[] backgroundSprites;

    void Start()
    {
        backgroundSprites = Resources.LoadAll<Sprite>("GameSceneObjects/BGs");

        if (backgroundSprites.Length == 0)
        {
            Debug.LogError("Не знайдено спрайтів у Resources/InGameObjects/BGs");
            return;
        }

        int index = Random.Range(0, backgroundSprites.Length-1);

        backgroundImage.sprite = backgroundSprites[index];
        //backgroundImage.sprite = backgroundSprites[3];
    }
}
