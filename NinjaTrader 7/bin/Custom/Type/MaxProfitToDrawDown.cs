// 
// Copyright (C) 2006, NinjaTrader LLC <www.ninjatrader.com>.
//
#region Using declarations
using System;
using System.ComponentModel;
using System.Drawing;
using NinjaTrader.Cbi;
using NinjaTrader.Data;
using NinjaTrader.Indicator;
using NinjaTrader.Strategy;
#endregion

// This namespace holds all strategies and is required. Do not change it.
namespace NinjaTrader.Strategy
{
	/// <summary>
	/// </summary>
	[Gui.Design.DisplayName("Max profit to drawdown ratio")]
	public class MaxProfitToDrawDown : OptimizationType
	{
		/// <summary>
		/// Return the performance value of a backtesting result.
		/// </summary>
		/// <param name="systemPerformance"></param>
		/// <returns></returns>
		public override double GetPerformanceValue(SystemPerformance systemPerformance)
		{
			return -systemPerformance.AllTrades.TradesPerformance.Points.CumProfit/systemPerformance.AllTrades.TradesPerformance.Points.DrawDown;
			//return systemPerformance.AllTrades.TradesPerformance.Points.CumProfit;
			//return systemPerformance.AllTrades.TradesPerformance.Points.DrawDown;
		}
	}
}
