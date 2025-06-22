using UnityEngine;
using UnityEngine.UI;

public class OnOffVolumeManager : MonoBehaviour
{
    [SerializeField] private Image soundOnIcon;
    [SerializeField] private Image soundOffIcon;

    [SerializeField] private AudioSource musicSource; // 🎵 Призначити музику

    private bool muted = false;
    private const string PlayerPrefsKey = "mutedMusic";

    void Start()
    {
        if (!PlayerPrefs.HasKey(PlayerPrefsKey))
        {
            PlayerPrefs.SetInt(PlayerPrefsKey, 0); // За замовчуванням не вимкнено
        }

        Load();
        UpdateButtonIcon();
        musicSource.mute = muted;
    }

    public void OnButtonPress()
    {
        muted = !muted;
        musicSource.mute = muted;
        Save();
        UpdateButtonIcon();
    }

    private void UpdateButtonIcon()
    {
        soundOnIcon.enabled = !muted;
        soundOffIcon.enabled = muted;
    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt(PlayerPrefsKey) == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt(PlayerPrefsKey, muted ? 1 : 0);
        PlayerPrefs.Save();
    }
}
