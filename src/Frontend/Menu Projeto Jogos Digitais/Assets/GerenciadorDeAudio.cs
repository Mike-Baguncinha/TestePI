using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorDeAudio : MonoBehaviour
{
    // Refer�ncia ao objeto de �udio da m�sica de fundo
    public GameObject musicaDeFundo;

    // Nomes das cenas de tela de t�tulo e do menu inicial
    public string nomeDaCenaDeTitulo;
    public string nomeDaCenaDoMenuInicial;

    void Start()
    {
        // Garante que o objeto de �udio da m�sica de fundo n�o seja destru�do ao trocar de cena
        DontDestroyOnLoad(musicaDeFundo);

        // Verifica se estamos em uma cena de menu
        string cenaAtual = SceneManager.GetActiveScene().name;
        if (cenaAtual == nomeDaCenaDeTitulo || cenaAtual == nomeDaCenaDoMenuInicial)
        {
            // Ativa a m�sica de fundo
            musicaDeFundo.SetActive(true);
        }
        else
        {
            // Desativa a m�sica de fundo se n�o estivermos em uma cena de menu
            musicaDeFundo.SetActive(false);
        }
    }

    // M�todo chamado quando um bot�o "Jogar" � clicado para iniciar o jogo
    public void IniciarJogo()
    {
        // Desativa a m�sica de fundo quando o jogo come�a
        musicaDeFundo.SetActive(false);
    }
}
