using UnityEngine;

public class CheckpointTarkistus : MonoBehaviour
{


    public int orderIndex = 0;

    private void OnTriggerEnter(Collider other){

        if(other.name == "Player"){
            //Debug.Log($"Portista {orderIndex} ajettu: {other.name}");

            var kierrostarkistaja = other.GetComponentInParent<PelaajanKierrostarkistus>();
            if (kierrostarkistaja != null)
            {
                kierrostarkistaja.MarkVisited(orderIndex);
            
            }
        }

    }
}
