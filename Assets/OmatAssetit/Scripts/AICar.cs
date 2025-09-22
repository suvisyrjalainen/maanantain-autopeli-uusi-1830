using UnityEngine;

public class AICar : MonoBehaviour
{
    public Transform[] waypoints;

    public float speed = 5f;
    public float turnSpeed = 50f;

    private int currentWpIndex = 0;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform target = waypoints[currentWpIndex];

        Vector3 targetXYZ = new Vector3(target.position.x, target.position.y, target.position.z);

        
    }
}
