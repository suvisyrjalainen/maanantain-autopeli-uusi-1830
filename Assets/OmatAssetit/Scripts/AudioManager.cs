using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance {get; private set;}
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public AudioSource musicSource; //looppaava taustamusiikki
    public AudioSource sfxSource; //yksittäiset äänet

   void Awake()
   {
    //Tämä pitää huolen ettei pelissä ole useita audio managereita
    if (Instance != null && Instance != this) { Destroy(gameObject); return; }
       Instance = this;
       DontDestroyOnLoad(gameObject);
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMusic(AudioClip musiikki){
        
        if(musicSource.isPlaying){
            musicSource.Stop();
        }
        
        musicSource.clip = musiikki;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip aani){
        sfxSource.PlayOneShot(aani);
    }


}
