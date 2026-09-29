using UnityEngine;
using UnityEngine.SceneManagement;//biblioteca utilizada para manipular poder usar as cenas !

public class Player : MonoBehaviour
{
    public float speed = 10f;
    private bool isGrounded = false;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();// conectar o script ao componente Rigidbody2D

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //Vai reconhecer o movimento horizontal

        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y); //Vai aplicar a velocidade horizontal ao Rigidbody2D

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
          rb.AddForce(new Vector2(0f, 8f), ForceMode2D.Impulse); //Vai aplicar uma força vertical ao Rigidbody2D
        }
    
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;// quando o jogador estiver com o player tocando no chão
        }

        if (collision.gameObject.CompareTag("Dano"))
        {
            SceneManager.LoadScene(0); //O player encostou no componete com teag Dano, Volta cena 0;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
        
            isGrounded = false;// quando o jogador não estiver com o player tocando no chão
        }
    }

}
