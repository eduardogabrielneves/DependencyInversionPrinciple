namespace AtividadeDIP
{
    public class Switch
    {
        private readonly IDevice _device;

        public Switch(IDevice device) => _device = device;

        public void Press() => _device.Operate();
    }
}
