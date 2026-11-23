using Classes_and_properties;

int[][] marks = new int[3][];
marks[0] = new int[] { 2, 5, 4, 5 };
marks[1] = new int[] { 7, 11, 9 };
marks[2] = new int[] { 6, 10, 9, 7, 3, 11 };
Student student = new Student("Johnson", "John", "Jackson", 22, marks);
Console.WriteLine(student);