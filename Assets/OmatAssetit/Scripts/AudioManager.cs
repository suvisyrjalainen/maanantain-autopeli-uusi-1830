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
        
        if(musicSource.clip == musiikki && musicSource.isPlaying){
            return;
        }
        
        musicSource.clip = musiikki;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void StopMusic(){
        musicSource.Stop();
    }

    public void PlaySFXLoop(AudioClip clip){
        
        if(sfxSource.clip == clip && sfxSource.isPlaying){
            return;
        }
        
        sfxSource.clip = clip;
        sfxSource.loop = true;
        sfxSource.Play();
    }

    public void StopSFX(){
        sfxSource.Stop();
    }

    public void PlaySFX(AudioClip clip){
        
        sfxSource.clip = clip;
        sfxSource.loop = false;
        sfxSource.Play();
    }


    

}
