﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Linq;
using Com.Aote.ObjectTools;
using System.Net;
using System.Collections.Generic;
using System.Json;
using Com.Aote.Behaviors;

namespace Com.Aote.Pages
{
    public partial class 抄表册状态查询 : UserControl
    {
        PagedList list = new PagedList();
        public 抄表册状态查询()
        {
            // Required to initialize variables
            InitializeComponent();
        }
    }
}