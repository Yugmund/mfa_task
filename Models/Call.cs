namespace mfa_task.Models;

public class Call
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string EmotionalTone { get; set; }
    public string Text { get; set; }
    public List<Category> Categories { get; set; }
}