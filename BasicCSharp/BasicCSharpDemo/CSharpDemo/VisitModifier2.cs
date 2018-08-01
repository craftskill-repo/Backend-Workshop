namespace BasicCSharpDemo.CSharpDemo
{
    public class VisitModifier2
    {
        public void testAcess()
        {
            VisitModifier vm =new VisitModifier();
            int b =  VisitModifier.a;
            int c = VisitModifier.b;
        }

        public static void main(string[] args)
        {
            VisitModifier vm = new VisitModifier();
        }
    }
}