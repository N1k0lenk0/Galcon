using UnityEngine;

public class ControlsPanelScript : MonoBehaviour
{
    public GameObject ControlsPanel;


     public void StartControlsTeaching()
    {
        ControlsPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void FinishControlsTeaching()
    {
        ControlsPanel.SetActive(false);
        Time.timeScale = 1f;
    }


}
