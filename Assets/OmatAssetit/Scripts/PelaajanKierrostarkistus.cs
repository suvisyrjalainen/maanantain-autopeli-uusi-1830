using UnityEngine;

public class PelaajanKierrostarkistus : MonoBehaviour
{

    public int checkpointCount = 5;

    // Tarkistaa, onko portit käyty läpi tällä kierroksella
    private bool[] visited;
    private int visitedCount = 0;

    public void MarkVisited(int index)
    {
        Debug.Log($"Olen mennyt juuri läpi portista: {index}");
        if (!visited[index])
        {
           visited[index] = true;
           visitedCount++;
           Debug.Log($"Olen mennyt läpi yhteensä {visitedCount} portista.");
        }
    }
}
