namespace ModuloDois.Modelos
{
    internal class ModificadorDeAcessoExemplo
    {
        public ModificadorDeAcessoExemplo()
        {
        }

        public bool Publico { get; internal set; }
        protected bool Protegido { get; }
        internal bool Interno { get; }
        private bool Privado { get; }
        protected internal bool ProtectedInternal { get; internal set; }
        private protected bool PrivateProtected { get; }
    }
}