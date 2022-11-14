namespace figuresCalculator
{
    public class figureCalculate
    {
        public float calculateCircle(float radius)
        {
            float result = MathF.PI * MathF.Pow(radius,2); // подсчёт радиуса по формуле
            return result==0?throw new Exception("Радиус задан неверно, площадь равна 0!"):result;
        }
        public float caltulateTriangle(float firstSide, float secondSide,float thirdSide =0)
        {
            if (thirdSide == 0) // проверка на третий параметр, что разделяет использование функции при подсчете площади треугольника и прямоугольника
                return firstSide * secondSide; // если прямоугольник - возвращаем площадь прямоугольника
            float p = (firstSide + secondSide + thirdSide) / 2;
            float result = MathF.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
            return result == 0 ? throw new Exception("Параметра заданы неверно, площадь равна 0!") : result; // иначе площадь треугольника
        }
    }
}