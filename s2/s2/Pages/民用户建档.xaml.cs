﻿using Com.Aote.Behaviors;
using Com.Aote.ObjectTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Com.Aote.Pages
{
	public partial class 民用户建档 : UserControl
	{
		public 民用户建档()
		{
            
			// Required to initialize variables
			InitializeComponent();
		} 
           private void f_address_MouseEnter(object sender, MouseEventArgs e)
           {
               f_address.Text = f_districtname.Text + f_cusDom.Text + f_cusDy.Text + f_cusFloor.Text + f_apartment.Text;
           }
	}
}