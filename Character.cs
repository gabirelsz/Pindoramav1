
// Codigo em C#, Nesta implementação, a classe Character possui informações 
// como nome, vida, atributos e listas de armas e venenos equipados.
// Ela tem métodos para calcular o dano de ataque total, equipar
// armas e venenos, usar poções de cura, aplicar efeitos de veneno
// em um inimigo e receber dano.

using System.Collections.Generic;

public class Character
{
    // Atributos
    public string Name { get; private set; }
    public int MaxHealth { get; private set; }
    public int CurrentHealth { get; private set; }
    public int Strength { get; private set; }
    public int Dexterity { get; private set; }
    public int Intelligence { get; private set; }
    public List<Weapon> EquippedWeapons { get; private set; }
    public List<Poison> EquippedPoisons { get; private set; }

    // Construtor
    public Character(string name, int maxHealth, int strength, int dexterity, int intelligence)
    {
        Name = name;
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
        Strength = strength;
        Dexterity = dexterity;
        Intelligence = intelligence;
        EquippedWeapons = new List<Weapon>();
        EquippedPoisons = new List<Poison>();
    }

    // Métodos
    public int CalculateAttackDamage()
    {
        int totalDamage = 0;
        foreach (Weapon weapon in EquippedWeapons)
        {
            totalDamage += weapon.CalculateTotalDamage(Strength);
        }
        return totalDamage;
    }

    public void EquipWeapon(Weapon weapon)
    {
        EquippedWeapons.Add(weapon);
    }

    public void EquipPoison(Poison poison)
    {
        EquippedPoisons.Add(poison);
    }

    public void UsePotion(Potion potion)
    {
        CurrentHealth = Mathf.Min(CurrentHealth + potion.HealAmount, MaxHealth);
    }

    public void ApplyPoisons(Enemy enemy)
    {
        foreach (Poison poison in EquippedPoisons)
        {
            poison.ApplyEffect(enemy);
        }
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth = Mathf.Max(CurrentHealth - damage, 0);
    }
}
