namespace CalculateAreaLib
{
    public class Circle : FigureBase
    {
        private readonly double _radius;
        /// <summary>
        /// Create circle by radius.
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            _radius = radius;
            CheckNegativeRadius();
        }

        private void CheckNegativeRadius()
        {
            if (_radius <= 0)
                throw new ArgumentException("Radius must be greater than zero");
        }

        public override double Calculate()
        {
            return Math.PI * _radius * _radius;
        }
    }

}