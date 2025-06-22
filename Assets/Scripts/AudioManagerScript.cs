using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    [SerializeField] AudioSource backgroundMusic;

    public AudioClip bgMusic;

    private void Start()
    {
        backgroundMusic.clip = bgMusic;
        backgroundMusic.Play();
    }
}
