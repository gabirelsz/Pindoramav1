public class Enemy
{
    public string name;
    public int health;
    public int attack;
    public int defense;

    public Enemy(string name, int health, int attack, int defense)
    {
        this.name = name;
        this.health = health;
        this.attack = attack;
        this.defense = defense;
    }

    public void Attack(Character player)
    {
        int damage = Mathf.Max(attack - player.defense, 0);
        player.health -= damage;
        Debug.Log(name + " causou " + damage + " de dano em " + player.name + ".");
    }
}




// A classe Enemy possui os atributos básicos de nome, saúde, ataque e defesa. O construtor é usado para inicializar esses valores.
// O método Attack é usado para causar dano ao personagem do jogador, calculando o dano com base no ataque do inimigo e defesa do jogador.
// Em seguida, o dano é subtraído da saúde do jogador e uma mensagem de log é impressa para informar o jogador sobre o ataque do inimigo.
