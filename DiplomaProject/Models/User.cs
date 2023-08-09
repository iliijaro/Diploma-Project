namespace DiplomaProject.Models;

public record User
{
    public UserType UserType { get; set; }
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("name")] public string Username { get; set; }
    public string Password { get; set; }
    [JsonPropertyName("email")] public string Email { get; set; }
}