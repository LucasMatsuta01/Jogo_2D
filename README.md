# Jogo_2D;

Jogo 2D;

25/08 - Hoje tivemos aula de versionamento de codigo, aprendemos oque é commit, pull, repositorio e etc, aprendemos tbm sobre git, github e gitdesktop;

27/08 - Hoje aprendi sobre GAME DESIGN e algumas mecanicas e variantes sobre o ramo, estudamos exemplos e debatemos sobre o ramo de jogos, aprendemos oque um game design faz, aprendemos que ele cuida da elaboração do projeto, compreendendo seus niveis, puzzles, artes, animações e etc;

22/09 - Hoje fizemos um script chamdo câmera follow, também fizemos um que faz o player somente pular quando encostar no chão, usando um var isGrounded.

24/09 - Durante o desenvolvimento do jogo no dia de hoje, iniciamos a construção do mapa do jogo, adicionei plataformas e obstáculos ao mapa.

29/09 - Hoje fizemos o mapa do nosso jogo, aprendi a usar Prefabs, isso serve para ter a organização do projeto, com ele você pode adicionar objetos no mapa sem ter que fazer de novo. Aprendi como funciona as cenas do jogo, agora sai como colocar cena de menu e como podemos mudar o personagem de lugar.

06/10 - Hoje fiz a cena de trofeu, funcionando, agora so falta o codigo de voltar.

08/10 - Hoje fiz uma pesquisa sobre o SceneManagement.

15/10 - hoje começamos a tela de reset, coloquei canvas e button.



{
O UnityEngine.SceneManagement é o namespace oficial do Unity responsável por controlar todas as cenas do seu jogo. Pense nele como o painel de controle que gerencia o fluxo dos cenários, permitindo carregar, descarregar, consultar e organizar as fases ou telas do seu projeto. Para ter acesso a essas ferramentas em qualquer script, precisamos sempre declarar a sua importação no topo do código usando using UnityEngine.SceneManagement;.

Neste nosso estudo, iremos utilizar a função SceneManager.GetSceneByName.

Diferente de comandos que carregam ou trocam de cena bruscamente, o GetSceneByName funciona como uma ferramenta de consulta e investigação. Quando passamos o nome de uma cena para ela — como a nossa cena "Trofeu" —, o Unity busca essa cena no projeto e nos devolve um objeto cheio de informações úteis.

Vamos usar essa função principalmente para:

Verificar a existência: Conferir se a cena "Trofeu" realmente faz parte do projeto e está configurada corretamente nas Build Settings.

Checar o estado atual: Descobrir se a cena já está carregada na memória ou se ainda está fechada, permitindo que o nosso script tome decisões inteligentes (como evitar carregar a mesma cena duas vezes) sem atrapalhar a experiência do jogador.
}
