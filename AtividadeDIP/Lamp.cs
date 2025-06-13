namespace AtividadeDIP
{
    public class Lamp : IDevice
    {
        private StateEnum state;

        public Lamp(StateEnum initialState) => state = initialState;

        public void Operate()
        {
            state = state == StateEnum.On ? StateEnum.Off : StateEnum.On;
            Console.WriteLine("Luz " + (state == StateEnum.On ? "Ligada" : "Desligada"));
        }
    }
}
