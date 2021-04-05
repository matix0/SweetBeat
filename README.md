# Brasa-Hack--Sweet-Beat

Músicas conectam gerações, e foi na música dos jogos rítmicos e musicais, como a série Guitar Hero, e no espírito aventureiro de jogos plataforma que o time Wildcards se inspirou para criar o Sweet Beat.

Sweet Beat é um jogo single player 2D, onde o jogador irá guiar Twinkle & Star em uma jornada por Candy Land!

Com movimentos simples (up/down) mas muito dinâmicos, você ganha pontos ao acertar as nuvens. Nas nuvens com rastros, clique várias vezes para coletar pontos!

O jogo foi criado utilizando a plataforma Unity, onde a linguagem C# foi usada para a criação de scripts. Os obstáculos do jogo foram definidos com a ajuda de um arquivo JSON, derivado de um arquivo MIDI da música utilizada.

Neste repositório consta o código utilizado para rodar o jogo, bem comos todos os elementos audio-visuais necessários.

## Instalação

Para abrir e rodar o código é necessária a ferramenta Unity (última versão estável: 2020.3.0 ).

## Uso

A ferramenta já inclui todas as bibliotecas e elementos necessários para o funcionamento do jogo.

## Possíveis bugs

Foi observado que é possível que nem todas as telas apareçam corretamente elencadas na hierarquia do projeto, para o funcionamento esperado, a hierarquia deve conter primeiramente o cenário "TelaInicial" e, logo depois, "joguinho". 

Em alguns casos pode ocorrer de não haver as sprites de nuvem (elementos visuais de batida para serem pressionadas) elencadas ao seu GameObject no script de "ObstacleManager", o esperado é encontrar tais objetos com a sprite de mesmo nome.
