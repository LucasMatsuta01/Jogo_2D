# Jogo_2D;

Jogo 2D;

25/08 - Hoje tivemos aula de versionamento de codigo, aprendemos oque é commit, pull, repositorio e etc, aprendemos tbm sobre git, github e gitdesktop;

27/08 - Hoje aprendi sobre GAME DESIGN e algumas mecanicas e variantes sobre o ramo, estudamos exemplos e debatemos sobre o ramo de jogos, aprendemos oque um game design faz, aprendemos que ele cuida da elaboração do projeto, compreendendo seus niveis, puzzles, artes, animações e etc;

22/09 - Hoje coloquei o pulo e a camera e a movimentação no player, aprendi como se faz isso e como colocar o MainCamer no player

24/09 - Hoje fiz desenvolvi o mapa de acordo com meu GDD, coloquei alguns obstaculos como espinhos.

27/09- Hoje criei a tag DANO que eu ja havia tentado criar, porem so consegui hoje, aprendi um pouco sobre cenas, e como funciona a ordem delas e que elas começam pelo 0.


{
O UnityEngine.SceneManagement é o namespace oficial do Unity responsável por controlar todas as cenas do seu jogo. Pense nele como o painel de controle que gerencia o fluxo dos cenários, permitindo carregar, descarregar, consultar e organizar as fases ou telas do seu projeto. Para ter acesso a essas ferramentas em qualquer script, precisamos sempre declarar a sua importação no topo do código usando using UnityEngine.SceneManagement;.

Neste nosso estudo, iremos utilizar a função SceneManager.GetSceneByName.

Diferente de comandos que carregam ou trocam de cena bruscamente, o GetSceneByName funciona como uma ferramenta de consulta e investigação. Quando passamos o nome de uma cena para ela — como a nossa cena "Trofeu" —, o Unity busca essa cena no projeto e nos devolve um objeto cheio de informações úteis.

Vamos usar essa função principalmente para:

Verificar a existência: Conferir se a cena "Trofeu" realmente faz parte do projeto e está configurada corretamente nas Build Settings.

Checar o estado atual: Descobrir se a cena já está carregada na memória ou se ainda está fechada, permitindo que o nosso script tome decisões inteligentes (como evitar carregar a mesma cena duas vezes) sem atrapalhar a experiência do jogador.
}
