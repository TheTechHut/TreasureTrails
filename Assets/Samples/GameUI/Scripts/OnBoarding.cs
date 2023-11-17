using UnityEngine;
using UnityEngine.SceneManagement;

public class OnBoarding : MonoBehaviour{

    public void OpenHomePageScene()
    {
        SceneManager.LoadScene("HomeScene");
        Debug.Log("Navigated to home page");
    }
}