using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitFromPause : MonoBehaviour
{
    [SerializeField] private Button mainMenuButton;

    private void Awake()
    {
        mainMenuButton.onClick.AddListener(() => {
            Application.Quit();
        });

    }
}