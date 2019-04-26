namespace Orm.Toolkit.Telerik.Windows.Controls
{
    internal class DialogWindowFactory : IDialogWindowFactory
    {
        public IRecurrenceChoiceDialogWindow CreateRecurrenceChoiceDialogWindow()
        {
            return new RecurrenceChoiceDialogWindow();
        }

        public IAppointmentDeleteDialogWindow CreateAppointmentDeleteDialogWindow()
        {
            return new AppointmentDeleteDialogWindow();
        }
        public IAppointmentClosingDialogWindow CreateAppointmentClosingDialogWindow()
        {
            return new AppointmentClosingDialogWindow();
        }
        public IAppointmentDialogWindow CreateAppointmentDialogWindow()
        {
            return new AppointmentDialogWindow();
        }
    }
}
