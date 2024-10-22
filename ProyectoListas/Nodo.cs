namespace ProyectoListas
{
    public class Nodo
    {
        private int valor;
        private Nodo sig;

        public Nodo(int valor)
        {
            this.valor = valor;
            sig = null;
        }

        public int Valor { get => valor; set => valor = value; }
        internal Nodo Sig { get => sig; set => sig = value; }
    }
}