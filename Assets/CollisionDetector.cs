using UnityEngine.SceneManagement;
using UnityEngine;

public class CollisionDetector : MonoBehaviour // parent class for all collissions
{
    public void goToPolarBearExhibit()
    {
        SceneManager.LoadScene("PolarBearExhibit");
    }

    public void goToSettings()
    {
        SceneManager.LoadScene("Settings");
    }
}
