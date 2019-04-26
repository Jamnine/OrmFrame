namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// UpDownMode determines the format ot the value.
    /// </summary>
    public enum ValueFormat
    {
        /// <summary>
        /// Formats value using fixed point notation using thousand separator.
        /// </summary>
        /// <value>0</value>
        Numeric,

        /// <summary>
        /// Formats value in currency notation.
        /// </summary>
        /// <value>1</value>
        Currency,

        /// <summary>
        /// Formats value in percentage notation, according to a decimal value.
        /// </summary>
        /// <value>2</value>
        Percentage
    }
}