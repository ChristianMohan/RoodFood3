using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace RoodFood3
{
    public class MainViewModel
    {
        public ObservableCollection<Food> Foods { get; set; }

        public MainViewModel()
        {
            Foods = new ObservableCollection<Food>
            {
                new Food
                {
                    Title = "Big Mac"
                },
                new Food
                {
                    Title = "McChicken"
                }
            };
        }
    }
}