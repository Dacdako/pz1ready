using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace пз1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ColorRGB mcolor { get; set; }

        public Color clr { get; set; }
        public MainWindow()
        {
            InitializeComponent();

                mcolor = new ColorRGB();
                mcolor.red = 0;
                mcolor.green = 0;
                mcolor.blue = 0;
              


            
        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            this.Inke.Strokes.Clear();
        }
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //if(selele.IsChecked.Value == true)this.Inke.EditingMode = InkCanvasEditingMode.Select;
            //else this.Inke.EditingMode = InkCanvasEditingMode.None;
            if (this.Inke.EditingMode == InkCanvasEditingMode.Select)
            {
                this.Inke.EditingMode = InkCanvasEditingMode.Ink;
            }
            else this.Inke.EditingMode = InkCanvasEditingMode.Select;
        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
            
        {
            try
            {

                string imgPath = @"Изображения";
                MemoryStream ms = new MemoryStream();
                FileStream fs = new FileStream(imgPath, FileMode.Create);
                RenderTargetBitmap rtb = new RenderTargetBitmap((int)Inke.Width, (int)Inke.Height, 96, 96, PixelFormats.Default);
                rtb.Render(Inke);
                GifBitmapEncoder gifEnc = new GifBitmapEncoder();
                gifEnc.Frames.Add(BitmapFrame.Create(rtb));
                gifEnc.Save(fs);
                fs.Close();
                MessageBox.Show("Файл сохранен, " + imgPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public class ColorRGB
        {
            public byte red { get; set; }
            public byte green { get; set; }
            public byte blue { get; set; }
            public ColorRGB mcolor { get; set; }

            public Color clr { get; set; }
        }
        //private void btn_Color_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    var slider = sender as Slider;
        //    string crlName = slider.Name; 
        //    double value = slider.Value; 
                                        
        //    if (crlName.Equals("btn_RedColor"))
        //    {
        //        mcolor.red = Convert.ToByte(value);
        //    }
        //    if (crlName.Equals("btn_GreenColor"))
        //    {
        //        mcolor.green = Convert.ToByte(value);
        //    }
        //    if (crlName.Equals("btn_BlueColor"))
        //    {
        //        mcolor.blue = Convert.ToByte(value);
        //    }
        //    clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
        //    this.Inke.DefaultDrawingAttributes.Color = clr;
        //}

        private void blue_Click(object sender, RoutedEventArgs e)
        {
            
            this.Inke.DefaultDrawingAttributes.Color = ((SolidColorBrush)Blue.Background).Color;
            
        }

        private void red_Click(object sender, RoutedEventArgs e)
        {
            this.Inke.DefaultDrawingAttributes.Color = ((SolidColorBrush)red.Background).Color;
        }

        private void green_Click(object sender, RoutedEventArgs e)
        {
            this.Inke.DefaultDrawingAttributes.Color = ((SolidColorBrush)Green.Background).Color;
        }

        private void Purple_Click(object sender, RoutedEventArgs e)
        {
            this.Inke.DefaultDrawingAttributes.Color = ((SolidColorBrush)Purple.Background).Color;
        }

        private void Black_Click(object sender, RoutedEventArgs e)
        {
            this.Inke.DefaultDrawingAttributes.Color = ((SolidColorBrush)Black.Background).Color;
        }

        private void White_Click(object sender, RoutedEventArgs e)
        {
            this.Inke.DefaultDrawingAttributes.Color = ((SolidColorBrush)White.Background).Color;
        }

        private void Pink_Click(object sender, RoutedEventArgs e)
        {
            this.Inke.DefaultDrawingAttributes.Color = ((SolidColorBrush)Pink.Background).Color;
        }

        private void Orange_Click(object sender, RoutedEventArgs e)
        {
            this.Inke.DefaultDrawingAttributes.Color = ((SolidColorBrush)Orange.Background).Color;
        }

        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
            this.Inke.DefaultDrawingAttributes.Color = ((SolidColorBrush)Yellow.Background).Color;
        }

        private void Gray_Click(object sender, RoutedEventArgs e)
        {
            this.Inke.DefaultDrawingAttributes.Color = ((SolidColorBrush)Gray.Background).Color;
        }

        private void text_Click(object sender, RoutedEventArgs e)
        {
            TextBox tt = new TextBox
            {
                Width = 100,
                Height = 50,
                BorderThickness = new Thickness(1),
                BorderBrush = new SolidColorBrush(Color.FromRgb(5, 5, 5)),
                Margin = new Thickness(20, 20, 0, 0)
                
            };
            
            this.Inke.Children.Add(tt);
        }
    }
}
