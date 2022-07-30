namespace EigeneExceptions
{
    [System.Serializable]
    public class MeinFehlerException : System.Exception
    {
        public MeinFehlerException() { }
        public MeinFehlerException(string message) : base(message) { }
        public MeinFehlerException(string message, System.Exception inner) : base(message, inner) { }
        protected MeinFehlerException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}