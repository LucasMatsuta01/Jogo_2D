using UnityEngine;
using UnityEngine.SceneManagement; // Essencial para gerenciar as cenas

public class Vitoria : MonoBehaviour
{
    public string nomeDaCenaTrofeu = "Trofeu"; // Nome da cena que será aberta

    // quando o Player colidir com o trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se tem a tag "Player"
        if (other.CompareTag("Player"))
        {
            // Verifica o estado da cena antes de carregar (usando o GetSceneByName)
            VerificarECarregarCena();
        }
    }

    void VerificarECarregarCena()
    {
        // Pega a referência da cena pelo nome
        Scene cenaTrofeu = SceneManager.GetSceneByName("Trofeu");

        // Verifica se a cena existe nas Build Settings
        if (SceneManager.GetSceneByName("Trofeu").IsValid())
        {
            Debug.Log("A cena 'Trofeu' foi encontrada no projeto!");

            // Se ela já estiver carregada, vai avisa
            if (cenaTrofeu.isLoaded)
            {
                Debug.Log("A cena 'Trofeu' já está carregada na memória.");
            }
            else
            {
                // Se não estiver carregada, carrega
                SceneManager.LoadScene("Trofeu");
            }
        }
        else
        {
            Debug.Log("Aviso: A cena '" + nomeDaCenaTrofeu + "' não foi encontrada ou não está adicionada nas Build Settings!");

            //se não deu certo ele faz o loadcena
            SceneManager.LoadScene("inicio");
        }
    }
}