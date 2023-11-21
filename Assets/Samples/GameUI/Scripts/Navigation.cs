using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour{

public void OpenGeospatialScene()
{
SceneManager.LoadScene("Geospatial");
Debug.Log("Navigated to gameplay page");
}

}


