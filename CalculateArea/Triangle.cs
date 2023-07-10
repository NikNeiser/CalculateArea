namespace CalculateAreaLib
{
    public class Triangle : FigureBase
    {
        private readonly double[] _sides = new double[3];

        /// <summary>
        /// return true if triangle is rectangled
        /// </summary>
        public bool TriangleIsRectangled { get; }

        /// <summary>
        /// Create triangle by 3 sides.
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double side1, double side2, double side3)
        {
            _sides[0] = side1;
            _sides[1] = side2;
            _sides[2] = side3;
            Array.Sort(_sides);

            CheckNegativeSides();
            CheckImpossibleSides();            

            TriangleIsRectangled = RectangledTriangleCheck();
        }

        private void CheckImpossibleSides()
        {
            if (_sides[2] >= _sides[0] + _sides[1])
                throw new ArgumentException("Greater side can't be greater than summ of other sides");
        }

        private void CheckNegativeSides()
        {
            if (_sides[0] <= 0)
                throw new ArgumentException("All sides must be greater than zero");
        }

        public override double Calculate()
        {
            return HeronsFormula();
        }

        private double HeronsFormula()
        {
            double halfPerimetr = _sides.Sum() / 2;
            return Math.Sqrt(halfPerimetr *
                (halfPerimetr - _sides[0]) *
                (halfPerimetr - _sides[1]) *
                (halfPerimetr - _sides[2]));
        }

        private bool RectangledTriangleCheck()
        {
            return _sides[0] * _sides[0] +
                _sides[1] * _sides[1] == _sides[2] * _sides[2];
        }

    }

}