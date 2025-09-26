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
        //otetaan listan ensimmäinen kohdepiste
        Transform target = waypoints[currentWpIndex];

        //otetaan targetista XZ-vektori
        Vector3 targetXZ = new Vector3(target.position.x, target.position.y, target.position.z);
        
        Vector3 direction = (targetXZ - transform.position).normalized;

        // Lasketaan käännös suuntaa kohti
        Quaternion lookRotation = Quaternion.LookRotation(direction);

        // Käännetään autoa pehmeästi kohti kohdetta
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, turnSpeed * Time.deltaTime);

        // Liikutaan eteenpäin auton oman etuakselin suuntaan
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Jos auto on tarpeeksi lähellä kohdepistettä (alle 2 yksikköä)
        if (Vector3.Distance(transform.position, target.position) < 2f)
        {
            // Siirrytään seuraavaan reittipisteeseen (ja palataan alkuun kun loppu saavutetaan)
            currentWpIndex = (currentWpIndex + 1) % waypoints.Length;
        }






    }
}
