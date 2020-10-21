using UnityEngine;

public class JankToSettingsButton : CollisionDetector
{
    public void OnTriggerEnter(Collider other)  // call parent method
    {
        goToSettings();
    }
}
