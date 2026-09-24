using UnityEngine;
using UnityEngine.SceneManagement;

public class movimento : MonoBehaviour
{
    public float speed = 5f;
    private bool isGrounded = false;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();// conectar o script ao componente Rigidbody2D

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Dano"))
        {
            SceneManager.LoadScene(0);
        }
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
