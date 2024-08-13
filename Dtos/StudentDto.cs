namespace Practice.Api.Dtos;

public record class StudentDto(
    int Id,
    string name,
    string surName,
    int age
);