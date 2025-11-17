using UnityEngine;
using TMPro;
using System.Collections;

public class Countdown : MonoBehaviour
{
    public TMP_Text countdownText;
    public int countdownFrom = 3;
    public float stepSeconds = 2f;


     private IEnumerator Start()
     {
        yield return new WaitForSecondsRealtime(1);

        for (int laskuri = countdownFrom; laskuri > 0; laskuri--)
        {

            countdownText.text = laskuri.ToString();

            yield return new WaitForSecondsRealtime(stepSeconds);
        }

        countdownText.text = "GO!";

        yield return new WaitForSecondsRealtime(stepSeconds);

        countdownText.text = "";


     }
}
