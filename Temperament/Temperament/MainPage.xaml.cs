using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Temperament
{
    public partial class MainPage : CarouselPage
    {
        Button btn,btn1,btn2,btn3,flegbtn,sanbtn,holbtn,melbtn;
        Uri ur;
        Label lblhol, lblmel, lblsan, lblfleg;
        public MainPage()
        {

            btn = new Button { Text = "Пройти тест" , BackgroundColor=Color.YellowGreen, HorizontalOptions = LayoutOptions.Center };
            btn1 = new Button { Text = "Пройти тест", BackgroundColor = Color.YellowGreen, HorizontalOptions = LayoutOptions.Center };
            btn2 = new Button { Text = "Пройти тест", BackgroundColor = Color.YellowGreen, HorizontalOptions = LayoutOptions.Center };
            btn3 = new Button { Text = "Пройти тест", BackgroundColor = Color.YellowGreen , HorizontalOptions= LayoutOptions.Center};
            lblhol = new Label { Margin = 20, Text = " " };
            lblmel = new Label { Margin = 20, Text = " " };
            lblsan = new Label { Margin = 20, Text = " " };
            lblfleg = new Label { Margin = 20, Text = " " };
                      
            flegbtn = new Button { ImageSource = "flegmatik.jpg", HeightRequest = 300 };
            holbtn = new Button { ImageSource = "holerik.jpg", HeightRequest = 300 };
            melbtn = new Button { ImageSource = "melanholik.jpg", HeightRequest = 200 };
            sanbtn = new Button { ImageSource = "sangvinik.jpg", HeightRequest = 300 };
            flegbtn.Clicked += Flegbtn_Clicked;
            sanbtn.Clicked += Sanbtn_Clicked;
            melbtn.Clicked += Melbtn_Clicked;
            holbtn.Clicked += Holbtn_Clicked;
            btn.Clicked += Btn_Clicked;
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked; btn3.Clicked += Btn3_Clicked;
            
            var holerikcontentpage = new ContentPage
            {
                
                Content = new StackLayout
                {

                    Children=
                    {
                        new Label{Text="Холерик", BackgroundColor= Color.Cornsilk, HorizontalTextAlignment= TextAlignment.Center, FontSize=20},
                        holbtn,
                        lblhol,
                        btn, }
                    
                        
                        

                }

            };
            var flegmatikcontentpage = new ContentPage
            {

                Content = new StackLayout
                {
                    Children =
                    {
                        new Label{Text="Флегматик", BackgroundColor= Color.Cornsilk, HorizontalTextAlignment= TextAlignment.Center, FontSize=20},
                        flegbtn, lblfleg,
                          btn1
                    }
                }
                
            };
            var sangvinikcontentpage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label{Text="Сангвиник", BackgroundColor= Color.Cornsilk, HorizontalTextAlignment= TextAlignment.Center, FontSize=20},
                        sanbtn, lblsan,
                        
                        btn2
                    }
                }
            };
            var melanholikcontentpage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                       new Label{Text="Меланхолик", BackgroundColor= Color.Cornsilk, HorizontalTextAlignment= TextAlignment.Center, FontSize=20},
                       melbtn,lblmel,
                        
                        btn3
                }
                }
            };
            Children.Add(melanholikcontentpage);
            Children.Add(flegmatikcontentpage);
            Children.Add(holerikcontentpage);
            Children.Add(sangvinikcontentpage);
        }

        private void Holbtn_Clicked(object sender, EventArgs e)
        {
            lblhol.Text = "Среди особенностей этого типа – он никогда не сидит на месте, способен преодолевать многие трудности, но подвержен резким переменам настроения, сильным эмоциональным вспышкам. Холерик – это человек-непоседа, вечный двигатель, который все время куда-то спешит, пытается сделать несколько дел одновременно, однако не всегда доводит их до конца.";
        }

        private void Melbtn_Clicked(object sender, EventArgs e)
        {
            lblmel.Text = "Меланхоликам подходит творческая работа, которая не требует проявления инициативы и общения со значительным количеством человек, а также не подверженная большому количеству изменений. Помимо повышенной чувствительности, представителям этого темперамента свойственна и повышенная наблюдательность, что также позволяет им добиться успеха в различных областях, подходящих под их темперамент. Начальников-меланхоликов практически не бывает, поскольку они мало приспособлены к управленческой работе. ";
        }

        private void Sanbtn_Clicked(object sender, EventArgs e)
        {
            lblsan.Text = "Сангвиник — самый сильный и яркий тип темперамента. Его представителей отличает высокая работоспособность, психическая активность, энергичность, но также непостоянство и порой слишком легкое отношение к проблемам.";
        }

        private void Flegbtn_Clicked(object sender, EventArgs e)
        {
            lblfleg.Text = "Флегматический тип темперамента можно назвать золотой серединой по сравнению с другими. Благодаря своему спокойствию такие люди часто оказывают благотворное влияние на действенного сангвиника, не обращают внимания на завышенные требования меланхолика и способны сдерживать резкие порывы холерика. ";
        }

        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            ur = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            await Browser.OpenAsync(ur);
        }

            private async void Btn2_Clicked(object sender, EventArgs e)
        {
            ur = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            await Browser.OpenAsync(ur);
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            ur = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            await Browser.OpenAsync(ur);
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            ur = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            await Browser.OpenAsync(ur);
        }
    }
}
