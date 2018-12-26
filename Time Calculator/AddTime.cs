﻿namespace Time_Calculator
{
    using System;
    using System.Windows.Forms;

    public partial class AddTime : Form
    {
        public AddTime()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var time = DateTime.Parse(enterTimeTextBox.Text);
            var timeToAdd = DateTime.Parse(addTimeTextBox.Text);
            string output = String.Format("{0:HH:mm}",time.Add(timeToAdd.TimeOfDay));
            calculateButton.Text = output;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            new SubtractTime().Show();
            this.Hide();
        }
    }
}