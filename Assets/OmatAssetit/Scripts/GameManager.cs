using UnityEngine;

public enum RacePhase { Countdown, Racing, Finished }

public class GameManager : MonoBehaviour
{

    public static GameManager Instance { get; private set; }

    public RacePhase Phase {get; set;} = RacePhase.Countdown;

    void Awake()
   {
    //Tämä pitää huolen ettei pelissä ole useita game managereita
    if (Instance != null && Instance != this) { Destroy(gameObject); return; }
       Instance = this;
       DontDestroyOnLoad(gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
