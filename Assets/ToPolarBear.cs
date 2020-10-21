using UnityEngine;

public class ToPolarBear : CollisionDetector
{
    public void OnTriggerEnter(Collider other)  // call parent method
    {
        goToPolarBearExhibit();
    }
}
