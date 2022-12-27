using Csv;
using System.Text.Json;
public class PokemonFileService
{
    public string CsvPath { get; }
    public string JsonPath { get; }

    public PokemonFileService(string basePath)
    {
        CsvPath = basePath + "./files/pokemon.csv";
        JsonPath = basePath + "./files/pokemon.json";
    }

     private static Func<ICsvLine, Pokemon> lineToPokemon =
      (ICsvLine line) =>
                {
                    var id = Int16.Parse(line[0]);
                    var name = line[1];
                    var Type1 = line[2];
                    var Type2 = line[3];
                    var total = Int16.Parse(line[4]);
                    var hp = Int16.Parse(line[5]);
                    var attack = Int16.Parse(line[6]);
                    var defense = Int16.Parse(line[7]);
                    var spAtk = Int16.Parse(line[8]);
                    var spDef = Int16.Parse(line[9]);
                    var speed = Int16.Parse(line[10]);
                    var generation = Int16.Parse(line[11]);
                    var legendary = line[12] == "True";
                    var types = Type2 == ""
                        ? new string[] { Type1 }
                        : new string[] { Type1, Type2 };

                    return new Pokemon(
                        id,
                        name,
                        types,
                        total,
                        hp,
                        attack,
                        defense,
                        spAtk,
                        spDef,
                        speed,
                        generation,
                        legendary
                    );
                };
    public IEnumerable<Pokemon> ReadPokemonCSV() =>
        CsvReader
            .ReadFromText(File.ReadAllText(CsvPath), new CsvOptions {
                HeaderMode = HeaderMode.HeaderAbsent
            })
            .Select(lineToPokemon);

    public void WritePokemonToJsonFile(IEnumerable<Pokemon> pokemon) 
    {   
        var jsonString = JsonSerializer.Serialize(pokemon);
        File.WriteAllText(JsonPath, jsonString);
    }
}