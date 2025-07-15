using UnityEngine;

public class Jogador : MonoBehaviour
{
    const float velocidade = 5f;
    [SerializeField] bool jogador1;
    [SerializeField] Color corDoJogador; // Cor do jogador

    private Vector2 direcao;

    void Update()
    {
        // Movimento baseado nas teclas de movimento configuradas
        if (jogador1)
        {
            if(Input.GetKey(KeyCode.A))
            {
                direcao.x = -1;
            }
            else if(Input.GetKey(KeyCode.D))
            {
                direcao.x = 1;
            }
            else 
            { 
                direcao.x = 0; 
            }

            if (Input.GetKey(KeyCode.S))
            {
                direcao.y = -1;
            }
            else if (Input.GetKey(KeyCode.W))
            {
                direcao.y = 1;
            }
            else
            {
                direcao.y = 0;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                direcao.x = -1;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                direcao.x = 1;
            }
            else
            {
                direcao.x = 0;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                direcao.y = -1;
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                direcao.y = 1;
            }
            else
            {
                direcao.y = 0;
            }
        }

        transform.Translate(direcao * velocidade * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Se o jogador colidir com um bloco, ele conquista o territ�rio
        if (other.CompareTag("Block"))
        {
            Bloco bloco = other.GetComponent<Bloco>();
            if (!bloco.PegarConquistado())
            {
                bloco.AlterarConquista(jogador1, corDoJogador); // Pinta o bloco com a cor do jogador
            }
        }
    }
}
