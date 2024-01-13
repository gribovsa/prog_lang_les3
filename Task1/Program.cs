double CalculateFormula(int a, int b, int c, int d)
{
    double numinator = a * b; //выбираем тип данных как более вместительный, чтобы результат был более вместительный double и отображал дробь
    int denominate = c + d;
    double result = numinator / denominate;
    return result;
}

CalculateFormula(1, 2, 3, 4); //задаем аргументы (уже аргументы а не параметры)

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);