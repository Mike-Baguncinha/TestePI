using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorDeAudio : MonoBehaviour
{
    // Referência ao objeto de áudio da música de fundo
    public GameObject musicaDeFundo;

    // Nomes das cenas de tela de título e do menu inicial
    public string nomeDaCenaDeTitulo;
    public string nomeDaCenaDoMenuInicial;

    void Start()
    {
        // Garante que o objeto de áudio da música de fundo não seja destruído ao trocar de cena
        DontDestroyOnLoad(musicaDeFundo);

        // Verifica se estamos em uma cena de menu
        string cenaAtual = SceneManager.GetActiveScene().name;
        if (cenaAtual == nomeDaCenaDeTitulo || cenaAtual == nomeDaCenaDoMenuInicial)
        {
            // Ativa a música de fundo
            musicaDeFundo.SetActive(true);
        }
        else
        {
            // Desativa a música de fundo se não estivermos em uma cena de menu
            musicaDeFundo.SetActive(false);
        }
    }

    // Método chamado quando um botão "Jogar" é clicado para iniciar o jogo
    public void IniciarJogo()
    {
        // Desativa a música de fundo quando o jogo começa
        musicaDeFundo.SetActive(false);
    }
}
