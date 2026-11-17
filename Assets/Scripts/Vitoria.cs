using UnityEngine;
using UnityEngine.SceneManagement; // Essencial para gerenciar as cenas

public class Vitoria : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trofeu"))
        {
            SceneManager.LoadScene("Trofeu");
        }
        if (collision.gameObject.CompareTag("fase2"))
        {
            SceneManager.LoadScene("fase2");
        }
    }
    public void Trofeu()
    {

       // SceneManager.LoadScene("Trofeu");
    }

}