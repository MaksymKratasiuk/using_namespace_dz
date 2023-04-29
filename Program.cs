namespace using_namespace_dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-2
            TicTacToeS ticTacToeS = new TicTacToeS();
            ticTacToeS.Play();
            TicTacToeM ticTacToeM = new TicTacToeM();
            ticTacToeM.Play();
            //3-4
            Test3_4.num3_4();
        }
    }
}