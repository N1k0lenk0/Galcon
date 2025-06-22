using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource;     // Джерело звуку (має бути з AudioClip)

    public void PlaySoundOnClick()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
