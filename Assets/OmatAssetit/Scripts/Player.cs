using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    public float turnSpeed = 10f;

    public AudioClip aani;
    public AudioClip musiikki;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //AudioManager.Instance.PlayMusic(musiikki);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Phase != RacePhase.Racing)
        {
            return;
        }
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(0, 0, move);
        transform.Rotate(0, turn, 0); 

        if(move != 0){
            AudioManager.Instance.PlaySFX(aani);
            //AudioManager.Instance.PlayMusic(musiikki);
        }
    }
}
