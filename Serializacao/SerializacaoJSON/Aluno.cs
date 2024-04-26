using System.Text.Json.Serialization;

namespace SerializacaoJSON;
public class Aluno
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    [JsonIgnore]// desta forma, esta propriedade Idade não será serializada
    public int Idade { get; set; }
    public Aluno()
    {
    }
    public Aluno(int id, string name, string email, int idade)
    {
        Id = id;
        Name = name;
        Email = email;
        Idade = idade;
    }
}
