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
        Button btn;
        Uri ur;
        public MainPage()
        {

            btn = new Button { Text = "Пройти тест" , BackgroundColor=Color.YellowGreen, HorizontalOptions = LayoutOptions.Center };
            Button btn1 = new Button { Text = "Пройти тест", BackgroundColor = Color.YellowGreen, HorizontalOptions = LayoutOptions.Center };
            Button btn2 = new Button { Text = "Пройти тест", BackgroundColor = Color.YellowGreen, HorizontalOptions = LayoutOptions.Center };
            Button btn3 = new Button { Text = "Пройти тест", BackgroundColor = Color.YellowGreen , HorizontalOptions= LayoutOptions.Center};
            
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
                        new Image{Source = "holerik.jpg", },
                        new Label{Text="Среди особенностей этого типа – он никогда не сидит на месте, способен преодолевать многие трудности, но подвержен резким переменам настроения, сильным эмоциональным вспышкам. Холерик – это человек-непоседа, вечный двигатель, который все время куда-то спешит, пытается сделать несколько дел одновременно, однако не всегда доводит их до конца. В отличие от сангвиника, холерика сложно назвать жизнерадостным — его энергичность порой приобретает форму конфликтности."},


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
                        new Image{Source = "flegmatik.jpg", },
                        new Label{Text="Флегматический тип темперамента можно назвать золотой серединой по сравнению с другими. Благодаря своему спокойствию такие люди часто оказывают благотворное влияние на действенного сангвиника, не обращают внимания на завышенные требования меланхолика и способны сдерживать резкие порывы холерика. Среди всех типов темперамента флегматики выступают в качестве своеобразного компенсатора, который не впадает в крайности, не создает лишних проблем и поддерживает баланс в коллективе."},
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
                        new Image{Source = "sangvinik.jpg", },
                        new Label{Text="Сангвиник — самый сильный и яркий тип темперамента. Его представителей отличает высокая работоспособность, психическая активность, энергичность, но также непостоянство и порой слишком легкое отношение к проблемам. "},

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
                       new Image{Source = "melanholik.jpg", },
                        new Label{Text="Меланхоликам подходит творческая работа, которая не требует проявления инициативы и общения со значительным количеством человек, а также не подверженная большому количеству изменений. Помимо повышенной чувствительности, представителям этого темперамента свойственна и повышенная наблюдательность, что также позволяет им добиться успеха в различных областях, подходящих под их темперамент. Начальников-меланхоликов практически не бывает, поскольку они мало приспособлены к управленческой работе. Однако если такое все же произошло, то босс-меланхолик достаточно либерален и чутко относится к подчиненным, но при этом не забывает о своих требовательности и перфекционизме."},

                        btn3
                }
                }
            };
            Children.Add(melanholikcontentpage);
            Children.Add(flegmatikcontentpage);
            Children.Add(holerikcontentpage);
            Children.Add(sangvinikcontentpage);
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
