using UnityEngine;
using TMPro;
using System.Collections;

public class Countdown : MonoBehaviour
{
    public TMP_Text countdownText;
    public int countdownFrom = 3;
    public float stepSeconds = 2f;
    public AudioClip pling;


     private IEnumerator Start()
     {
        yield return new WaitForSecondsRealtime(1);
        
        for (int laskuri = countdownFrom; laskuri > 0; laskuri--)
        {
            AudioManager.Instance.PlaySFX(pling);
            countdownText.text = laskuri.ToString();

            yield return new WaitForSecondsRealtime(stepSeconds);
        }

        AudioManager.Instance.PlaySFX(pling);
        countdownText.text = "GO!";

        GameManager.Instance.Phase = RacePhase.Racing;

        yield return new WaitForSecondsRealtime(stepSeconds);

        countdownText.text = "";


     }
}
