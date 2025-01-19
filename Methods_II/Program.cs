namespace Methods_II
{
    internal class Program
    {
        //Fields (or instance variable) - sometimes called global variable
        //int num;
        //float num2;

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            int num = myProgram.ReturnANumber(1);

            Console.WriteLine(num);

            float num2 = ReturnAFloat(3.3f);
        }

        int ReturnANumber(int num)
        {
            return num;
        }

        static float ReturnAFloat(float num)
        {
            return num;
        }
    }
}
