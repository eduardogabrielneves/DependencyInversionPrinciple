namespace AtividadeDIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDevice lamp = new Lamp(StateEnum.Off);
            Switch _switch = new Switch(lamp);

            _switch.Press();
            _switch.Press();
        }
    }
}
