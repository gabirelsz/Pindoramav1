# Pindoramav1
Pindoramav1


Um jogo de RPG dungeon crawler que será feito em Unity 2d Mobile, o jogo não tem cenario onde você anda, as cenas vão de uma luta para a outra
até a sala de descanso.

Nome do jogo: Pindoramav1

Um jogo rpg mobile 2d em turnos feito em Unity, não existe mapa e não existe movimentação, são apenas cenários de lutas, cada sala é uma cena
de batalha. menu inicial, inventário, tela de conversa com aliados pós algumas batalhas e tela de status do personagem

O layout do combate é parecido com o layout de combate de jogos como "Dark of Alchemist - Dungeon Crawler RPG" e "Burriedbornes".



Background do jogo:

Somos um originario guarani homem chamado "Tupi", lutando contra os colonizadores europeus, fazendo alianças com civilizações originarias da
mesma regiao, como incas e aztecas.



Combate do jogo:

O combate do jogo se dá em turnos, o personagem principal possui 2 armas equipadas, um arco e flecha e uma faca pequena, ele tem ainda 3
espaços para venenos que poderão ser equipados individualmente em qualquer uma das armas no começo de cada turno. Você possui 5 poções de cura
e ganha + 5 a cada 10 combates. Ela cura 25% do HP máximo do Personagem.






O que você pode fazer em cada turno: 

Encantar até 3 venenos na mesma arma, quando você clica em um botao de veneno (existem 3 botões de veneno na tela, um para cada veneno
equipado) e depois clica em uma das armas, você encanta a arma com o veneno escolhido. não é possivel encantar o mesmo veneno em duas armas
diferentes ao mesmo tempo.

atacar com uma arma envenenada, existem dois botões (um para cada arma equipada atualmente no Tupi) de ataque na interface proximo aos botões
de venenos,  quando você clicar na arma duas vezes seguidas em um intervalo menor que 0,3 segundo, você ira atacar. É possivel atacar sem
envenenar a arma. 

Usar uma poção de cura (existe um botão também proximo aos botões de arma e venenos, que serve para usar uma poção de cura.)




Tentar fugir da batalha, quando você foge, existe uma chance de 25% de você morrer e perder seu personagem e o jogo recomeçar do inicio, se
você conseguir fugir da batalha, irá para a proxima luta sem ganhar nada.

Toda vez que você ataca, seu turno termina e o inimigo inicia o turno dele.


A ordem do turno funciona assim assim:

No começo da batalha você tem as opções:

Encantar até 3 venenos na mesma arma, não é possivel encantar o mesmo veneno em duas armas diferentes. Quando você encanta qualquer veneno, é
obrigatório ficar com seu efeito na arma escolhida por no minimo 3 turnos.

Usar uma poção de cura. 2 usos máximos por batalha.

Tentar fugir da batalha, quando você foge, existe uma chance de 25% de você morrer e perder seu personagem e o jogo recomeçar do inicio, se
você conseguir fugir da batalha, irá para a proxima luta sem ganhar 1 level e sem ganhar itens.


explicações:


Venenos: existem 3 venenos no jogo. Teremos mais.

Necroveneno = Adiciona a STR total do usuario como dano adicional a arma quando equipar o veneno nela.
Fogoveneno = Adiciona a AGI total do usuario como dano adicional a arma quando equipar o veneno nela, mas quando você ataca tem 25% de chance
de tomar dano de aproximação (dano de aproximação: você toma 30% do dano causado no ultimo turno).
Luzveneno = Você se cura em Dex total do usuario se estiver ferido toda vez que atacar.

Armas: Existem 3 armas no jogo atualmente, teremos mais. Só é possivel estar equipado com duas armas no maximo, Você pode equipar apenas uma
arma, o bonus de dano baseado no atributo daquela arma será dobrado se fizer isso.

Arco = Dano basico é 10 e mais a Dex total do usuario.
Faca = Dano basico é 15 e mais a Agi total do usuario.
Lança = Dano basico é 30 e mais a STR total do usuario.
Espada Gelada = Dano basico 5 e mais a STR total do usuario.


Itens:
Poção de cura: cura 25% da vida máxima do usuario.

Atributos: existem 3 atributos atualmente no jogo, teremos mais. O personagem começa com 2 de cada atributo, a cada vez que mata um inimigo
em batalha, ele sobe de nivel e assim ganha +1 de atributo do dano bonus das armas equipadas na batalha com o inimigo morto, se estiver com
apenas uma arma equipada, ganha 1.5 ao invés de 1 ponto.

Str = Tupi começa com 2
Agi = Tupi começa com 2
Dex = Tupi começa com 2


status basico do personagem no começo do jogo (o seu nome é Tupi):

Level: 1
Atributos iniciais do Tupi:
STR = 2
DEX = 2
AGI = 2

Vida inicial do Tupi: 255.

Armas equipadas iniciais de tupi: Arco e Faca.

Venenos equipados inicialmente em tupi: Luzveneno, Fogoveneno, Necroveneno.

Como sobe de nivel? Sobe de nivel sempre que mata um inimigo em batalha, é a unica forma de subir de nivel.

O que ganha ao subir de nivel? ganha +1 de atributo do dano bonus das armas equipadas na batalha com o inimigo que você derrotou por último e
15 de vida máxima, mas não cura a vida atual do usuario.

Inimigos atuais existente no jogo: 

Sujo do Mar:
Level = sempre no mesmo level do Tupi
Hp = entre 20% até 50% do hp máximo atual de Tupi
Arma equipada = Espada Gelada
Item = 1 Poção de cura
STR = 2
DEX = 2
AGI = 2

Comportamento em luta: Usa sempre o ataque da espada gelada todos os rounds, quando chega em 50% de vida, usa sua poção de cura.




Para criar este jogo em Unity, preciso criar as seguintes classes:

Character: Esta classe representará o personagem jogável Tupi e conterá suas informações de atributos, armas equipadas e venenos equipados. 
Ela também terá métodos para atacar, encantar venenos e usar poções de cura.

Weapon: Esta classe representará as armas que o personagem pode equipar. Ela terá informações como nome, dano base e atributo bônus, e também
terá um método para calcular o dano total do ataque.

Poison: Esta classe representará os venenos que o personagem pode encantar em suas armas. Ela terá informações como nome e efeito, e terá um
método para aplicar seu efeito em uma arma.

Potion: Esta classe representará as poções de cura que o personagem pode usar. Ela terá informações como nome e quantidade de cura, e terá um
método para curar o personagem.

Enemy: Esta classe representará os inimigos que o personagem enfrentará em combate. Ela terá informações como nome, atributos e vida, e terá
métodos para atacar o personagem e calcular o dano.

TurnManager: Esta classe gerenciará a ordem dos turnos no combate. Ela terá um método para determinar qual personagem ou inimigo deve agir a
seguir, e um método para verificar se a batalha acabou.

Além disso, preciso criar interfaces gráficas para exibir as informações do personagem e do inimigo, bem como os botões para encantar venenos,
atacar e usar poções de cura. Preciso também criar animações para os ataques e as ações do personagem e dos inimigos.
