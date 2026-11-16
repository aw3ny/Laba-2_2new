namespace ClassLibrary1
{
    public class OurClassLibrary
    {
        public static double Max(double[,] matrix)
        {
            double MaxMain = matrix[0, 0];
            double MaxSide = matrix[0, 6];
            for (int i = 0; i < 7; i++)
            {
                if (matrix[i,i] > MaxMain)
                {
                    MaxMain = matrix[i,i];
                }
                if (matrix[i,6-i] > MaxSide)
                {
                    MaxSide = matrix[i,6-i];
                }
            }
            return MaxMain *MaxSide;
        }
    }
}
