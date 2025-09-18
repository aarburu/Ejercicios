/*
Idatzi 3x3 tamainako bi matrize sortu eta 0tik 9 arteko ausazko
balioekin bete eta erakusten duen programa. Ondoren, bi matrize
horien batura hirugarren matrize batean gorde eta erakutsi.
*/

var MatrixDimension = 3;
var matrix1 = Utils.CreateMatrix(MatrixDimension);
var matrix2 = Utils.CreateMatrix(MatrixDimension);
var matrix3 = Utils.CreateMatrix(MatrixDimension);
var matrix4 = Utils.CreateMatrix(MatrixDimension);
var matrix5 = Utils.CreateMatrix(MatrixDimension);

Console.WriteLine();
Console.WriteLine("Matriz 1:");
Utils.DisplayMatrix(matrix1);

Console.WriteLine();
Console.WriteLine("Matriz 2:");
Utils.DisplayMatrix(matrix2);

Console.WriteLine();
Console.WriteLine("Matriz 3:");
Utils.DisplayMatrix(matrix3);

Console.WriteLine();
Console.WriteLine("Matriz 4:");
Utils.DisplayMatrix(matrix4);

Console.WriteLine();
Console.WriteLine("Matriz 5:");
Utils.DisplayMatrix(matrix5);

Console.WriteLine();
Console.WriteLine("Matriz Resultado: ");
var resultMatrix = Utils.SumMatrixes(MatrixDimension, matrix1, matrix2, matrix3, matrix4, matrix5);
Utils.DisplayMatrix(resultMatrix);

    

