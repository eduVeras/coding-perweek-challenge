namespace Coding.PerWeek.Challenge.Challenges._2023.May
{
    public class SpiralOrderProblem
    {
        public List<int> SpiralOrder(int[][] matrix)
        {
            List<int> resultado = new List<int>();
            int linhaInicial = 0;
            int linhaFinal = matrix.Length;
            int colunaInicial = 0;
            int colunaFinal = matrix[0].Length;

            while (linhaInicial < linhaFinal && colunaInicial < colunaFinal)
            {
                for (int i = colunaInicial; i < colunaFinal; i++)
                {
                    resultado.Add(matrix[linhaInicial][i]);
                }
                linhaInicial++;

                for (int i = linhaInicial; i < linhaFinal; i++)
                {
                    resultado.Add(matrix[i][colunaFinal - 1]);
                }
                colunaFinal--;

                if (linhaInicial < linhaFinal)
                {
                    for (int i = colunaFinal - 1; i >= colunaInicial; i--)
                    {
                        resultado.Add(matrix[linhaFinal - 1][i]);
                    }
                    linhaFinal--;
                }

                if (colunaInicial < colunaFinal)
                {
                    for (int i = linhaFinal - 1; i >= linhaInicial; i--)
                    {
                        resultado.Add(matrix[i][colunaInicial]);
                    }
                    colunaInicial++;
                }
            }

            return resultado;
        }

      
    }
}
