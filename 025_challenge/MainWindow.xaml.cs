using System;
using System.Collections.Generic;
using System.Linq;
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

namespace _025_challenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }
        //starting variables and arrays
        string[] items;
        string[] prices;
        int itemNumber = 0;
        int length;
        int num;
        double total;

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Change Labels            
            enterItemsLabel.Content = "Enter Items Below";
            itemNumberLabel.Content = "1";
            numberOfItemsLabel.Content = 0;

            //make variables 
            itemNumber = int.Parse(itemNumberBox.Text);
            length = itemNumber;
            num = length;

            //disable button and clear label
            button1.IsEnabled = false;
            button1.Content = "Number of Items in List:";
            label1.Content = "";

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //make size of arrays according to user input
            items = new string[itemNumber];
            prices = new string[itemNumber];

            //loop for adding items as long as num > 0
            if (num > 0)
            {
                //add items in text boxes to array
                items[length - num] = itemBox.Text;
                prices[length - num] = itemPriceBox.Text;

                //change labels to display new info each time item is added
                itemListLabel.Content += "\n  " + items[length - num] + " " + "$" + prices[length - num];
                itemNumberLabel.Content = (length - num) +2;
                numberOfItemsLabel.Content = (length - num) + 1;

                //add total each time button is pressed and display
                total += double.Parse(itemPriceBox.Text);
                totalCostLabel.Content = "$" + total;

                //subtract one from num each time till its at 0
                num--;
                
                //once num == 0 disable add button and clear labels
                if (num == 0) button2.IsEnabled = false;
                if (num == 0) label2.Content = "";
                if (num == 0) itemNumberLabel.Content = "";
            }
            
            //clear textBoxes
            itemBox.Text = "";
            itemPriceBox.Text = "";

        }
    }
}
