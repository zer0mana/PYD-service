namespace PYD_Service.Requests;

public record CreatePYDRequest(
    long GoalPoints,
    string Name,
    string Description);