using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    // TODO: SchedulerAnimation
    internal class SchedulerAnimation
    {
        private readonly RadScheduler scheduler;

        internal SchedulerAnimation(RadScheduler scheduler)
        {
            this.scheduler = scheduler;
        }

        /// <summary>
        /// Starts the view transition animation. Animation with resource key.
        /// </summary>
        internal void BeginViewTransitionAnimation(ViewTransitionMode mode)
        {
            var presenter = this.scheduler.FindChildByType<SchedulerPresenter>();
            if (presenter == null)
            {
                return;
            }

            var animation = presenter.TryFindResource(mode.ToString()) as Storyboard;
            if (animation == null)
            {
                return;
            }


            var transitionElement = this.scheduler.Template.FindName("TransitionImage", this.scheduler) as Image;
            if (transitionElement != null)
            {
                transitionElement.Source = GetImageSourceFromElement(presenter);
            }

            animation.Begin(this.scheduler, this.scheduler.Template);

        }


        private static ImageSource EncodeImage(BitmapSource renderBitmap)
        {
            var encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(renderBitmap));

            var stream = new MemoryStream();
            encoder.Save(stream);

            return BitmapFrame.Create(
                stream,
                BitmapCreateOptions.IgnoreImageCache | BitmapCreateOptions.DelayCreation,
                BitmapCacheOption.None);
        }

        private static ImageSource GetImageSourceFromElement(FrameworkElement element)
        {
            var bounds = new Rect(new Size(element.ActualWidth, element.ActualHeight));
            var renderBitmap = new RenderTargetBitmap(
                (int)bounds.Width, (int)bounds.Height, 96, 96, PixelFormats.Pbgra32);

            var visual = new DrawingVisual();
            using (DrawingContext context = visual.RenderOpen())
            {
                var brush = new VisualBrush(element);
                context.DrawRectangle(brush, null, bounds);
            }

            renderBitmap.Render(visual);
            renderBitmap.Freeze();

            if (BrowserInteropHelper.IsBrowserHosted)
            {
                return renderBitmap;
            }

            return EncodeImage(renderBitmap);
        }

    }
}