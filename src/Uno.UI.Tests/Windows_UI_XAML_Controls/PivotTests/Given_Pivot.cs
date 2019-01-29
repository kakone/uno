﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uno.Extensions;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;

namespace Uno.UI.Tests.PivotTests
{
	[TestClass]
	public class Given_Pivot
    {
		[TestMethod]
		public void When_Empty()
		{
			var SUT = new Pivot() { Name = "test" };

			var grid = new Grid();
			grid.Children.Add(SUT);
			grid.ForceLoaded();

			SUT.Measure(default(Size));
			SUT.Arrange(Rect.Empty);

			Assert.AreEqual(default(Size), SUT.DesiredSize);
			Assert.IsTrue(SUT.GetChildren().None());
		}
	}
}