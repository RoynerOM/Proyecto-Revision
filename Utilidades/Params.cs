namespace Utilidades
{
    public static class Params
    {
        public static int Icon { get; set; }
        public static string Message { get; set; }

        public static void Properties(int Number, string Message_)
        {
            Icon = Number;
            Message = Message_;
        }
    }
}
