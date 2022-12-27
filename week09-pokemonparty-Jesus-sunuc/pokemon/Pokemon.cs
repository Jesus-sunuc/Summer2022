public record class Pokemon(
    int Id,
    string Name,
    IEnumerable<string> Types,
    int Total,
    int HP,
    int Attack,
    int Defense,
    int SpAttack,
    int SpDefense,
    int Speed,
    int Generation,
    bool Legendary
);