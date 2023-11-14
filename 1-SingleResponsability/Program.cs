using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new(studentRepository);
Console.WriteLine("Proceso Completado");