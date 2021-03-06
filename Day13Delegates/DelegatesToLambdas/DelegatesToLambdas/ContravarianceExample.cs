﻿using NUnit.Framework;
using System;
using System.Diagnostics;


namespace SandBox.Tests.Delegates
{

    public class ChildEventArgs : EventArgs
    {
        
    }


    public class ContravarianceExample
    {
        // Define the delegate.
        public delegate void RaiseEventWithEventArgs(object sender, EventArgs e);

        public delegate void RaiseEventWithChildEventArgs(object sender, ChildEventArgs e);


        public static void DoWithEventArgs(object sender, EventArgs e)
        {
        }

        public static void DoWithChildEventArgs(object sender, DataReceivedEventArgs e)
        {
        }
     
        [Test]
        public void TestCovariance()
        {
            RaiseEventWithChildEventArgs raiseEventWithChildEventArgs = DoWithEventArgs;
            raiseEventWithChildEventArgs(this, new ChildEventArgs());
        }
    }
}


