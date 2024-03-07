namespace Eval_Gabriel.K_Guillaume.L
{
    public class ExceptionNombresNegatifs : Exception
    {
        public int NombreFautif { get; }
        public int Position { get; }

        public ExceptionNombresNegatifs(int nombreFautif, int position)
        {
            NombreFautif = nombreFautif;
            Position = position;
        }
    }
}
