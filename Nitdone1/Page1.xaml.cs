using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nitdone1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage

    {
        private bool taps;

        public Page1()
        {
            InitializeComponent();
            {
                {

                    Label mid1, mid2, mid3, mid4, mid5, mid6, mid7, mid8, mid9, mid10, p1, p2, p3, p4, p5, r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14;
                    {

                        Grid abs = new Grid();

                        for (int i = 0; i < 10; i++)

                        {

                            abs.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                        }


                        for (int i = 0; i < 5; i++)

                        {

                            abs.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

                        }


                        mid1 = new Label { BackgroundColor = Color.White };

                        abs.Children.Add(mid1, 0, 0);

                        Grid.SetColumnSpan(mid1, 2);

                        mid2 = new Label { BackgroundColor = Color.White, Text = "1" };

                        abs.Children.Add(mid2, 3, 0);

                        mid3 = new Label { BackgroundColor = Color.White, Text = "2" };

                        abs.Children.Add(mid3, 4, 0);

                        mid4 = new Label { BackgroundColor = Color.White, Text = "3" };

                        abs.Children.Add(mid4, 5, 0);

                        mid5 = new Label { BackgroundColor = Color.White, Text = "4" };

                        abs.Children.Add(mid5, 6, 0);

                        mid6 = new Label { BackgroundColor = Color.White, Text = "5" };

                        abs.Children.Add(mid6, 7, 0);

                        mid7 = new Label { BackgroundColor = Color.White, Text = "6" };

                        abs.Children.Add(mid7, 8, 0);

                        mid8 = new Label { BackgroundColor = Color.White, Text = "7" };

                        abs.Children.Add(mid8, 9, 0);

                        mid9 = new Label { BackgroundColor = Color.White, Text = "8" };

                        abs.Children.Add(mid9, 10, 0);

                        mid10 = new Label { BackgroundColor = Color.White, Text = "9" };

                        abs.Children.Add(mid10, 11, 0);



                        p1 = new Label { BackgroundColor = Color.White, Text = "Esmaspäev" };

                        abs.Children.Add(p1, 0, 1);

                        Grid.SetColumnSpan(p1, 2);

                        p2 = new Label { BackgroundColor = Color.White, Text = "Teisipäev" };

                        abs.Children.Add(p2, 0, 2);

                        Grid.SetColumnSpan(p2, 2);

                        p3 = new Label { BackgroundColor = Color.White, Text = "Kolmapäev" };

                        abs.Children.Add(p3, 0, 3);

                        Grid.SetColumnSpan(p3, 2);

                        p4 = new Label { BackgroundColor = Color.White, Text = "Neljapäev" };

                        abs.Children.Add(p4, 0, 4);

                        Grid.SetColumnSpan(p4, 2);

                        p5 = new Label { BackgroundColor = Color.White, Text = "Reede" };

                        abs.Children.Add(p5, 0, 5);

                        Grid.SetColumnSpan(p5, 2);



                        r1 = new Label { BackgroundColor = Color.Green, Text = "Keel ja \n Kirjandus" };
                        abs.Children.Add(r1, 3, 1);
                        Grid.SetColumnSpan(r1, 2);
                        var tap = new TapGestureRecognizer();
                        tap.Tapped += async (s, e) =>
                        {
                            r1 = (Label)s;
                            await DisplayAlert("Info", "Кабинет B221 \n Ljudmilla Mihhailova", "kinni");
                        };
                        r1.GestureRecognizers.Add(tap);

                        r2 = new Label { BackgroundColor = Color.DeepPink, Text = "Võrgud ja Seadm." };
                        abs.Children.Add(r2, 5, 1);
                        Grid.SetColumnSpan(r2, 3);
                        var tap1 = new TapGestureRecognizer();
                        tap1.Tapped += async (s, e) =>
                        {
                            r2 = (Label)s;
                            await DisplayAlert("Info", "Кабинет A123 \n Mikhail Agapov", "kinni");
                        };
                        r2.GestureRecognizers.Add(tap);

                        r3 = new Label { BackgroundColor = Color.LightBlue, Text = "Mob. Rak." };
                        abs.Children.Add(r3, 8, 1);
                        Grid.SetColumnSpan(r3, 3);
                        var tap2 = new TapGestureRecognizer();
                        tap2.Tapped += async (s, e) =>
                        {
                            r3 = (Label)s;
                            await DisplayAlert("Info", "Кабинет E07 \n Marina Oleinik", "kinni");
                        };
                        r3.GestureRecognizers.Add(tap);

                        r4 = new Label { BackgroundColor = Color.LightYellow, Text = "Transp.log.hut." };
                        abs.Children.Add(r4, 3, 2);
                        Grid.SetColumnSpan(r4, 3);
                        var tap3 = new TapGestureRecognizer();
                        tap3.Tapped += async (s, e) =>
                        {
                            r4 = (Label)s;
                            await DisplayAlert("Info", "B002 \n Jaanus Krull", "kinni");
                        };
                        r4.GestureRecognizers.Add(tap);

                        r5 = new Label { BackgroundColor = Color.Gray, Text = "Inglise W.hald" };
                        abs.Children.Add(r5, 7, 2);
                        Grid.SetColumnSpan(r5, 2);
                        var tap5 = new TapGestureRecognizer();
                        tap5.Tapped += async (s, e) =>
                        {
                            r5 = (Label)s;
                            await DisplayAlert("Info", "Кабинет B242 \n Julia Voronovska", "kinni");
                        };
                        r5.GestureRecognizers.Add(tap);

                        r6 = new Label { BackgroundColor = Color.DeepPink, Text = "Eesti keel \n teise kellena" };
                        abs.Children.Add(r6, 9, 2);
                        Grid.SetColumnSpan(r6, 2);
                        var tap6 = new TapGestureRecognizer();
                        tap6.Tapped += async (s, e) =>
                        {
                            r6 = (Label)s;
                            await DisplayAlert("Info", "Кабинет B236 \n Alina Laaneväli-Toots", "kinni");
                        };
                        r6.GestureRecognizers.Add(tap);

                        r7 = new Label { BackgroundColor = Color.DeepPink, Text = "W.paig.sead." };
                        abs.Children.Add(r7, 3, 3);
                        Grid.SetColumnSpan(r7, 3);
                        var tap7 = new TapGestureRecognizer();
                        tap7.Tapped += async (s, e) =>
                        {
                            r7 = (Label)s;
                            await DisplayAlert("Info", "Кабинет A243 \n Lury Shkarbanova", "kinni");
                        };
                        r7.GestureRecognizers.Add(tap);

                        r8 = new Label { BackgroundColor = Color.LightYellow, Text = "Transp.log.hut." };
                        abs.Children.Add(r8, 6, 3);
                        Grid.SetColumnSpan(r8, 5);
                        var tap8 = new TapGestureRecognizer();
                        tap8.Tapped += async (s, e) =>
                        {
                            r8 = (Label)s;
                            await DisplayAlert("Info", "B002 \n Jaanus Krull", "kinni");
                        };
                        r8.GestureRecognizers.Add(tap);

                        r9 = new Label { BackgroundColor = Color.Pink, Text = "Keemia \n Biologia" };
                        abs.Children.Add(r9, 11, 3);
                        var tap9 = new TapGestureRecognizer();
                        tap9.Tapped += async (s, e) =>
                        {
                            r9 = (Label)s;
                            await DisplayAlert("Info", "B144 \n Svetlana Pesetskaja", "kinni");
                        };
                        r9.GestureRecognizers.Add(tap);

                        r10 = new Label { BackgroundColor = Color.DeepPink, Text = "W.paig.sead." };
                        abs.Children.Add(r10, 3, 4);
                        Grid.SetColumnSpan(r10, 3);
                        var tap10 = new TapGestureRecognizer();
                        tap10.Tapped += async (s, e) =>
                        {
                            r10 = (Label)s;
                            await DisplayAlert("Info", "Кабинет A243 \n Lury Shkarbanova", "kinni");
                        };
                        r10.GestureRecognizers.Add(tap);

                        r11 = new Label { BackgroundColor = Color.DeepPink, Text = "Võrgud ja Seadm." };
                        abs.Children.Add(r11, 7, 4);
                        Grid.SetColumnSpan(r11, 2);
                        var tap11 = new TapGestureRecognizer();
                        tap11.Tapped += async (s, e) =>
                        {
                            r11 = (Label)s;
                            await DisplayAlert("Info", "Кабинет A123 \n Mikhail Agapov", "kinni");
                        };
                        r11.GestureRecognizers.Add(tap);

                        r12 = new Label { BackgroundColor = Color.Gray, Text = "Inglise W.hald" };
                        abs.Children.Add(r12, 9, 4);
                        Grid.SetColumnSpan(r12, 2);
                        var tap12 = new TapGestureRecognizer();
                        tap12.Tapped += async (s, e) =>
                        {
                            r12 = (Label)s;
                            await DisplayAlert("Info", "Кабинет B242 \n Julia Voronovska", "kinni");
                        };
                        r12.GestureRecognizers.Add(tap);

                        r13 = new Label { BackgroundColor = Color.Pink, Text = "Keemia \n Biologia" };
                        abs.Children.Add(r13, 3, 5);
                        var tap13 = new TapGestureRecognizer();
                        tap13.Tapped += async (s, e) =>
                        {
                            r13 = (Label)s;
                            await DisplayAlert("Info", "B144 \n Svetlana Pesetskaja", "kinni");
                        };
                        r13.GestureRecognizers.Add(tap);

                        r14 = new Label { BackgroundColor = Color.LightBlue, Text = "Mob. Rak." };
                        abs.Children.Add(r14, 5, 5);
                        Grid.SetColumnSpan(r14, 3);
                        var tap14 = new TapGestureRecognizer();
                        tap14.Tapped += async (s, e) =>
                        {
                            r14 = (Label)s;
                            await DisplayAlert("Info", "Кабинет E07 \n Marina Oleinik", "kinni");
                        };
                        r14.GestureRecognizers.Add(tap);
                        Content = abs;
                    }
                    {
                        throw new NotImplementedException();
                    }
                }
            }
        }
    }
}
