using UnityEngine;
using UnityEngine.SceneManagement;

public class OnBoarding : MonoBehaviour{

    public GameObject overlay;
    public void OpenHomePageScene()
    {
        SceneManager.LoadScene("HomeScene");
        Debug.Log("Navigated to home page");
    }

    public void OpenOverlay()
    {
        overlay.SetActive(true);
    }

     public void CloseOverlay()
    {
        overlay.SetActive(false);
    }
}