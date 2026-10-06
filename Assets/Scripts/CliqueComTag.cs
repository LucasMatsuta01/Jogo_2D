using UnityEngine;
using UnityEngine.SceneManagement;

public class CliqueComTag : MonoBehaviour
{
    public string cenaParaVoltar = "jogo";

    // Função para chamar quando o botão for clicado
    public void AoClicar()
    {
        // Verifica se este objeto tem a Tag correta
        if (gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene(cenaParaVoltar);
        }
    }
}