namespace Utilidades.Interfaces
{
    interface IAlertas<Form>
    {
        void Danger(Form form, string mensaje);
        void Success(Form form, string mensaje);
        void Info(Form form, string mensaje);
        void Warning(Form form, string mensaje);
    }
}
