public class Potion
{
    public string name;
    public int healingAmount;

    public Potion(string name, int healingAmount)
    {
        this.name = name;
        this.healingAmount = healingAmount;
    }

    public void Heal(Character character)
    {
        character.currentHealth += healingAmount;
        if (character.currentHealth > character.maxHealth)
        {
            character.currentHealth = character.maxHealth;
        }
    }
}



// Explicação da implementação:

// A classe Potion tem duas propriedades públicas: name, que representa o nome da poção, e healingAmount, que representa a quantidade de pontos de vida que a poção cura.
// O construtor da classe recebe essas informações como parâmetros e as atribui às propriedades correspondentes.
// O método Heal recebe um objeto Character como parâmetro e cura a quantidade de pontos de vida especificada pela propriedade healingAmount. O método também verifica se
// a cura excedeu o limite máximo de pontos de vida do personagem, definido pela propriedade maxHealth da classe Character. Se sim, o método define o valor de currentHealth
// como igual a maxHealth.
