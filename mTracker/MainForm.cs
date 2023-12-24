using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mTracker
{
    public partial class MainForm : Form
    {
        public List<Patterns> Patterns { get; set; }

        public List<Patterns> getPatterns()
        {
            var list = new List<Patterns>();

            list.Add(new Patterns()
            {
                Note = 0,
                Octave = 0
            });
            list.Add(new Patterns()
            {
                Note = 0,
                Octave = 0
            });
            list.Add(new Patterns()
            {
                Note = 0,
                Octave = 0
            });
            list.Add(new Patterns()
            {
                Note = 0,
                Octave = 0
            });

            return list;
        }

        public MainForm()
        {
            Patterns = getPatterns();

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
