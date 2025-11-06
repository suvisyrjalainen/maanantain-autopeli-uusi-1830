using UnityEngine;
using TMPro;

public class Tuomari : MonoBehaviour
{
    private bool voittajaSelvilla = false;

    public TMP_Text voittajaTeksti;

    void Start()
    {
        voittajaTeksti.text = "";
    }

    private void OnTriggerEnter(Collider car)
    {

        CarIdentify id = car.GetComponent<CarIdentify>();
        if (id == null)
        {
            return;
        }

        string winnerName = id.displayName;


        if (id.kind == CarKind.Player)
        {
            var validator = car.GetComponentInParent<PelaajanKierrostarkistus>();
            if (validator == null || !validator.AllVisitedThisLap)
            {
                Debug.Log("Pelaaja ylitti maalin, mutta kaikki checkpointit eivät ole kunnossa → ei voittoa.");
                return;
            }
        }


        if(!voittajaSelvilla){
            Debug.Log($"WINNER: {winnerName}");
            voittajaTeksti.color = new Color32(238, 201, 11, 255);
            voittajaTeksti.text = $"Voittaja on {winnerName}!!!";
            voittajaSelvilla = true;
        }


    }
}
