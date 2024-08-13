using Practice.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

const string getStudentEndpointName = "GetStudent";


List<StudentDto> students = [
    new(
        1,
        "Ajdin",
        "Omeragic",
        22
    ),
    new(
        2,
        "Ajdin",
        "Ibrahimkadic",
        22
    ),
    new(
        3,
        "Kenan",
        "Omrbegovic",
        22
    ),
    new(
        4,
        "Hajrudin",
        "Bajraktarevic",
        22
    ),

];

//GET /students
app.MapGet("students", () => students);

//GET /students/1
app.MapGet("students/{id}", (int id) => students.Find(student => student.Id == id)).WithName(getStudentEndpointName);

//POST /students
app.MapPost("students", (CreateStudentsDto newStudent) => {
    StudentDto student = new(
        students.Count +1,
        newStudent.name,
        newStudent.surName,
        newStudent.age);
    students.Add(student);
    return Results.CreatedAtRoute(getStudentEndpointName, new {id = student.Id}, student);
});
app.Run();
