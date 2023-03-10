using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private List<Character> characters = new List<Character>();
    private List<Enemy> enemies = new List<Enemy>();
    private int currentCharacterIndex = 0;
    private int currentEnemyIndex = 0;
    private bool isCharacterTurn = true;
    private bool isBattleOver = false;

    public void StartBattle(List<Character> characters, List<Enemy> enemies)
    {
        this.characters = characters;
        this.enemies = enemies;
        currentCharacterIndex = 0;
        currentEnemyIndex = 0;
        isCharacterTurn = true;
        isBattleOver = false;
    }

    public void Update()
    {
        if (!isBattleOver)
        {
            if (isCharacterTurn)
            {
                if (currentCharacterIndex >= characters.Count)
                {
                    currentCharacterIndex = 0;
                }
                characters[currentCharacterIndex].BeginTurn();
                currentCharacterIndex++;
                if (currentCharacterIndex >= characters.Count)
                {
                    isCharacterTurn = false;
                }
            }
            else
            {
                if (currentEnemyIndex >= enemies.Count)
                {
                    currentEnemyIndex = 0;
                }
                enemies[currentEnemyIndex].BeginTurn();
                currentEnemyIndex++;
                if (currentEnemyIndex >= enemies.Count)
                {
                    isCharacterTurn = true;
                }
            }

            if (characters.FindAll(c => c.IsDead()).Count == characters.Count)
            {
                isBattleOver = true;
                Debug.Log("You lose!");
            }

            if (enemies.FindAll(e => e.IsDead()).Count == enemies.Count)
            {
                isBattleOver = true;
                Debug.Log("You win!");
            }
        }
    }
}




// Essa classe mantém listas separadas de personagens e inimigos, e um índice para cada lista que rastreia qual personagem ou inimigo deve agir
// a seguir. A variável booleana isCharacterTurn indica se é a vez do personagem jogável ou do inimigo.

// O método StartBattle é chamado no início de uma batalha e recebe as listas de personagens e inimigos. Ele também reinicia os índices
// e as variáveis booleanas para seus valores iniciais.

// O método Update é chamado a cada frame e faz a lógica principal do turno. Se é a vez do personagem jogável, ele chama o método BeginTurn() do
// personagem atual e incrementa o índice. Se é a vez do inimigo, ele faz o mesmo com o inimigo atual. Quando chega ao final de uma lista, ele verifica se é o fim da rodada (quando ambos personagens e inimigos agiram) e alterna a variável booleana isCharacterTurn para indicar a próxima rodada.

// Por fim, o método Update verifica se algum dos lados venceu (ou seja, todos os personagens ou todos os inimigos foram derrotados) e encerra a
// batalha, exibindo a mensagem correspondente.
