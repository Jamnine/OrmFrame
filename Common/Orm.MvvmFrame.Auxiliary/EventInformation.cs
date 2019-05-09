namespace Orm.MvvmFrame.Auxiliary
{
    public class EventInformation<TEventArgsType>
    {
        public object Sender { get; set; }
        public TEventArgsType EventArgs { get; set; }
        public object CommandArgument { get; set; }
    }
}
