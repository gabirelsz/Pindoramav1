public class Poison {
    public string Name { get; private set; }
    public float Duration { get; private set; }
    public float DamagePerTick { get; private set; }

    public Poison(string name, float duration, float damagePerTick) {
        Name = name;
        Duration = duration;
        DamagePerTick = damagePerTick;
    }

    public void ApplyTo(Weapon weapon) {
        weapon.Enchant(this);
    }
}



// Explicação dos membros da classe:

// Name: nome do veneno.
// Duration: duração do veneno em segundos.
// DamagePerTick: dano que o veneno causa a cada intervalo de tempo.
// ApplyTo: método que aplica o efeito do veneno em uma arma, chamando o método Enchant da arma passando a si mesmo como parâmetro.
// Nota: esta é apenas uma implementação básica da classe Poison, e há muitas outras informações e funcionalidades que podem ser adicionadas de acordo com as necessidades do jogo.
