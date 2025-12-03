using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    public float turnSpeed = 10f;

    public AudioClip tyhjakaynti;
    public AudioClip ajo;
    public AudioClip liiraus;

    private bool isMovingSoundPlaying = false;
    private bool isSkidding = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioManager.Instance.PlayMusic(tyhjakaynti);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Phase != RacePhase.Racing)
        {
            if (GameManager.Instance.Phase == RacePhase.Finished){
                AudioManager.Instance.StopMusic();
                AudioManager.Instance.StopSFX();
            }
            return;
        }
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(0, 0, move);
        transform.Rotate(0, turn, 0); 

        if(move != 0 && !isMovingSoundPlaying){
            AudioManager.Instance.PlayMusic(ajo);
            isMovingSoundPlaying = true;
        }

        if(move == 0 && isMovingSoundPlaying){
            AudioManager.Instance.StopMusic();
            isMovingSoundPlaying = false;
            AudioManager.Instance.PlayMusic(tyhjakaynti);
        }

        if(move != 0 && turn != 0 && !isSkidding){
            AudioManager.Instance.PlaySFXLoop(liiraus);
            isSkidding = true;
        }
        if((move == 0 || turn == 0) && isSkidding){
            AudioManager.Instance.StopSFX();
            isSkidding = false;
        }
    }
}
