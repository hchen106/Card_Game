using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using CardGame.Model;
using System.Web;
using Newtonsoft.Json.Linq;
using System.Windows.Media.Animation;

namespace CardGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private deck deck_;
        private Boolean gameStart = false;
        public MainWindow()
        {
            InitializeComponent();

            
            HttpClient client = new HttpClient();

            var response = client.GetStringAsync("https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=6");

  
            JObject res = JObject.Parse(response.Result);
            this.deck_ = new deck(res["deck_id"].ToString());
            

        }

        private void start_button_Click(object sender, RoutedEventArgs e)
        {
            

            start_button.Visibility = Visibility.Hidden;


            call_animation(5);
            


            //trans.BeginAnimation(TranslateTransform.XProperty, anim1);


        }
        private void redraw_button_Click(object sender, RoutedEventArgs e)
        {
            var items = card_container_bottom.SelectedItems;
            int count = items.Count;
            Console.WriteLine(items.Count);
            for(int i =count-1; i >= 0; i--)
            {
                
                card_container_bottom.Items.Remove(items[i]);
                
            }

            
            

            call_animation(count);
            redraw_button.Visibility = Visibility.Hidden;


            //trans.BeginAnimation(TranslateTransform.XProperty, anim1);


        }

        private void call_animation(int count)
        {
            if (count > 0)
            {
                var target = back_image;
                back_image.Visibility = Visibility.Visible;
                TranslateTransform trans = new TranslateTransform();
                target.RenderTransform = trans;

                System.Windows.Media.Animation.DoubleAnimation anim2 = new System.Windows.Media.Animation.DoubleAnimation(100, 400, TimeSpan.FromSeconds(0.2));


                anim2.RepeatBehavior = new RepeatBehavior(count);
                anim2.Completed += new EventHandler((sender_, e_) => animation_completed(sender_, e_, count));
                trans.BeginAnimation(TranslateTransform.YProperty, anim2);
            }
        }
        private void animation_completed(object sender, EventArgs e, int count)
        {

            /*card c = deck_.drawCard();
            card_container.Items.Add(c);*/
            List<card> card_list = new List<card>();
            card_list = deck_.drawCard(count);
            for (int i = 0; i < card_list.Count; i++)
            {
                //list_box.Items.Add(card_list[i]);

                //card_grid.Children.Add(card_list[i]);
                //list_view.Items.Add(card_list[i]);
                card_container_bottom.Items.Add(card_list[i]);
                //trans.BeginAnimation(TranslateTransform.YProperty, anim2);

            }
            if(!gameStart)
            {
                redraw_button.Visibility = Visibility.Visible;
                gameStart = true;
            }
            else
            {
                redraw_button.Visibility = Visibility.Hidden;
                gameStart = false;
                
            }
            back_image.Visibility = Visibility.Hidden;
        }

       
    }
}
