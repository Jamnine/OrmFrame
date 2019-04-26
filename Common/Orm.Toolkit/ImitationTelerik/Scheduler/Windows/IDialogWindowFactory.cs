namespace Orm.Toolkit.Telerik.Windows.Controls
{
    internal interface IDialogWindowFactory
    {
        IRecurrenceChoiceDialogWindow CreateRecurrenceChoiceDialogWindow();
		IAppointmentDeleteDialogWindow CreateAppointmentDeleteDialogWindow();
        IAppointmentDialogWindow CreateAppointmentDialogWindow();
        IAppointmentClosingDialogWindow CreateAppointmentClosingDialogWindow();
    }
}
