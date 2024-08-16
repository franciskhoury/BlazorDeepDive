namespace WebAssemblyDemo.Client
{
    public class ContainerStorage
    {
        private string _message = String.Empty;

        public string GetMessage() { return _message; }

        public void SetMessage(string msg) { _message = msg; }
    }
}
