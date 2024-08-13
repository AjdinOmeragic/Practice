namespace Practice.Api.Dtos;

public record class CreateStudentsDto(
    string name,
    string surName,
    int age
);
