// Explicação: A classe Weapon possui quatro atributos privados: Name, BaseDamage, BonusAttribute e BonusAttributeValue.
// O construtor da classe recebe os valores de cada um desses atributos e os armazena nas propriedades correspondentes.
// A propriedade Name é apenas uma string que representa o nome da arma.
// A propriedade BaseDamage representa o dano base da arma.
// A propriedade BonusAttribute é um enum que representa o atributo bônus da arma (por exemplo, "força" ou "destreza").
// A propriedade BonusAttributeValue representa o valor desse atributo bônus.
// A classe também possui um método público CalculateTotalDamage que recebe como parâmetro o valor do atributo do personagem
// que está usando a arma e retorna o dano total do ataque, considerando o dano base da arma, o valor do atributo bônus da arma
// e o valor do atributo do personagem.

public class Weapon {
    public string Name { get; private set; }
    public int BaseDamage { get; private set; }
    public AttributeType BonusAttribute { get; private set; }
    public int BonusAttributeValue { get; private set; }

    public Weapon(string name, int baseDamage, AttributeType bonusAttribute, int bonusAttributeValue) {
        Name = name;
        BaseDamage = baseDamage;
        BonusAttribute = bonusAttribute;
        BonusAttributeValue = bonusAttributeValue;
    }

    public int CalculateTotalDamage(int characterAttributeValue) {
        return BaseDamage + BonusAttributeValue + characterAttributeValue;
    }
}
