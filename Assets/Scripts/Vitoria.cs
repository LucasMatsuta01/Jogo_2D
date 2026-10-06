using UnityEngine;
using UnityEngine.SceneManagement; // Para mudar a cena

public class Vitoria : MonoBehaviour
{
    public string Trofeu;

    // função executada quando colide com o trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se te a tag "Player"
        if (other.CompareTag("Player"))
        {
            // Carrega a nova cena
            SceneManager.LoadScene(Trofeu);
        }
    }
}