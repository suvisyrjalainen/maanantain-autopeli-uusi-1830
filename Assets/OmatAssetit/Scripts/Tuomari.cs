using UnityEngine;

public class Tuomari : MonoBehaviour
{
    private void OnTriggerEnter(Collider car)
    {
        CarIdentify id = car.GetComponent<CarIdentify>();
        if (id == null)
        {
            return;
        }

        string winnerName = id.displayName;
        Debug.Log($"WINNER: {winnerName}");
    }
}
