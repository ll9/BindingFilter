using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingFilter
{
    public partial class Form1 : Form
    {
        BindingList<Person> People = new BindingList<Person>(new[]
        {
            new Person(1, "Hans"),
            new Person(2, "Peter"),
            new Person(3, "Michael"),
            new Person(4, "Matthias"),
        });

        public Form1()
        {
            InitializeComponent();
            BindingList<Person> Filter = new BindingList<Person>(People.Where(x => x.Id > 1).ToList());


            FeaturesGrid.DataSource = People;


            FeaturesBox.BindingContext = new BindingContext();
            FeaturesBox.DataSource = Filter;
            FeaturesBox.DisplayMember = "Name";
        }
    }
}
