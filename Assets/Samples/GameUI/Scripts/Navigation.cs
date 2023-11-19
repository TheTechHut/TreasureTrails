using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour{

public GameObject coming_soon_overlay;




public void OpenGeospatialScene()
{
SceneManager.LoadScene("Geospatial");
Debug.Log("Navigated to gameplay page");
}

public void OnComingSoonTrigger()
{
    coming_soon_overlay.SetActive(true);
    float timer = 3.0f;
    timer -= Time.deltaTime;

    if(timer<0)
    {
        coming_soon_overlay.SetActive(false);
    }

    
}
}


