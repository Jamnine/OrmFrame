using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Orm.Toolkit
{
    public class CircularProgressBar : RangeBase
    {
        #region Ctor
        static CircularProgressBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CircularProgressBar), new FrameworkPropertyMetadata(typeof(CircularProgressBar)));

            MinimumProperty.OverrideMetadata(typeof(CircularProgressBar), new FrameworkPropertyMetadata(0D));
            MaximumProperty.OverrideMetadata(typeof(CircularProgressBar), new FrameworkPropertyMetadata(100D));
            SmallChangeProperty.OverrideMetadata(typeof(CircularProgressBar), new FrameworkPropertyMetadata(1D));
            LargeChangeProperty.OverrideMetadata(typeof(CircularProgressBar), new FrameworkPropertyMetadata(10D));
            BorderBrushProperty.OverrideMetadata(typeof(CircularProgressBar), new FrameworkPropertyMetadata(Brushes.LightGray));
            BorderThicknessProperty.OverrideMetadata(typeof(CircularProgressBar), new FrameworkPropertyMetadata(new Thickness(10), OnBorderThicknessChanged));
        }
        #endregion


        #region Methods
        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);

            ComputeProperties();
        }

        protected override void OnValueChanged(double oldValue, double newValue)
        {
            //
        }

        /// <summary>
        /// Re-computes the various properties that the elements in the template bind to.
        /// </summary>
        protected virtual void ComputeProperties()
        {
            if ((ActualHeight <= 0) || (ActualWidth <= 0))
                return;

            try
            {
                Angle = (Value - Minimum) * 360 / (Maximum - Minimum);
                CentreX = ActualWidth / 2;
                CentreY = ActualHeight / 2;
                Radius = Math.Min(CentreX, CentreY);
                Diameter = Radius * 2;
                InnerRadius = Radius * HoleSizeFactor;
                Percent = Angle / 360;
            }
            catch { }
        }
        #endregion

        #region Properties
        public double Percent
        {
            get { return (double)this.GetValue(CircularProgressBar.PercentProperty); }
            private set { this.SetValue(CircularProgressBar.PercentPropertyKey, value); }
        }

        private static readonly DependencyPropertyKey PercentPropertyKey =
            DependencyProperty.RegisterReadOnly("Percent",
            typeof(double), typeof(CircularProgressBar),
            new FrameworkPropertyMetadata(0D));

        public static readonly DependencyProperty PercentProperty =
            PercentPropertyKey.DependencyProperty;



        public double Diameter
        {
            get { return (double)this.GetValue(CircularProgressBar.DiameterProperty); }
            private set { this.SetValue(CircularProgressBar.DiameterPropertyKey, value); }
        }

        private static readonly DependencyPropertyKey DiameterPropertyKey =
            DependencyProperty.RegisterReadOnly("Diameter",
            typeof(double), typeof(CircularProgressBar),
            new FrameworkPropertyMetadata(0D));

        public static readonly DependencyProperty DiameterProperty =
            DiameterPropertyKey.DependencyProperty;



        public double Radius
        {
            get { return (double)this.GetValue(CircularProgressBar.RadiusProperty); }
            private set { this.SetValue(CircularProgressBar.RadiusPropertyKey, value); }
        }

        private static readonly DependencyPropertyKey RadiusPropertyKey =
            DependencyProperty.RegisterReadOnly("Radius",
            typeof(double), typeof(CircularProgressBar),
            new FrameworkPropertyMetadata(0D));

        public static readonly DependencyProperty RadiusProperty =
            RadiusPropertyKey.DependencyProperty;



        public double InnerRadius
        {
            get { return (double)this.GetValue(CircularProgressBar.InnerRadiusProperty); }
            private set { this.SetValue(CircularProgressBar.InnerRadiusPropertyKey, value); }
        }

        private static readonly DependencyPropertyKey InnerRadiusPropertyKey =
            DependencyProperty.RegisterReadOnly("InnerRadius",
            typeof(double), typeof(CircularProgressBar),
            new FrameworkPropertyMetadata(0D));

        public static readonly DependencyProperty InnerRadiusProperty =
            InnerRadiusPropertyKey.DependencyProperty;



        public double CentreX
        {
            get { return (double)this.GetValue(CircularProgressBar.CentreXProperty); }
            private set { this.SetValue(CircularProgressBar.CentreXPropertyKey, value); }
        }

        private static readonly DependencyPropertyKey CentreXPropertyKey =
            DependencyProperty.RegisterReadOnly("CentreX",
            typeof(double), typeof(CircularProgressBar),
            new FrameworkPropertyMetadata(0D));

        public static readonly DependencyProperty CentreXProperty =
            CentreXPropertyKey.DependencyProperty;



        public double CentreY
        {
            get { return (double)this.GetValue(CircularProgressBar.CentreYProperty); }
            private set { this.SetValue(CircularProgressBar.CentreYPropertyKey, value); }
        }

        private static readonly DependencyPropertyKey CentreYPropertyKey =
            DependencyProperty.RegisterReadOnly("CentreY",
            typeof(double), typeof(CircularProgressBar),
            new FrameworkPropertyMetadata(0D));

        public static readonly DependencyProperty CentreYProperty =
            CentreYPropertyKey.DependencyProperty;



        public double Angle
        {
            get { return (double)this.GetValue(CircularProgressBar.AngleProperty); }
            private set { this.SetValue(CircularProgressBar.AnglePropertyKey, value); }
        }

        public static readonly DependencyPropertyKey AnglePropertyKey =
            DependencyProperty.RegisterReadOnly("Angle",
            typeof(double), typeof(CircularProgressBar),
            new FrameworkPropertyMetadata(0D));

        public static readonly DependencyProperty AngleProperty =
            AnglePropertyKey.DependencyProperty;



        public double HoleSizeFactor
        {
            get { return (double)this.GetValue(HoleSizeFactorProperty); }
            set { SetValue(HoleSizeFactorProperty, value); }
        }

        public static readonly DependencyProperty HoleSizeFactorProperty =
            DependencyProperty.Register("HoleSizeFactor",
            typeof(double), typeof(CircularProgressBar),
            new FrameworkPropertyMetadata(0D, HoleSizeFactorChanged));

        private static void HoleSizeFactorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CircularProgressBar owner = (CircularProgressBar)d;
            double value = (double)e.NewValue;

            // Add handling.
        }


        public double StrokeThickness
        {
            get { return (double)this.GetValue(StrokeThicknessProperty); }
            set { SetValue(StrokeThicknessProperty, value); }
        }

        public static readonly DependencyProperty StrokeThicknessProperty =
            DependencyProperty.Register("StrokeThickness",
            typeof(double), typeof(CircularProgressBar),
            new UIPropertyMetadata(10D));
        #endregion


        #region Event Handlers
        private static void OnBorderThicknessChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CircularProgressBar owner = (CircularProgressBar)d;
            Thickness value = (Thickness)e.NewValue;

            owner.StrokeThickness = value.Left;
        }
        #endregion

    }
}
