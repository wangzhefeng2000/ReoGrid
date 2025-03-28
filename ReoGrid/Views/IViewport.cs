﻿/*****************************************************************************
 * 
 * ReoGrid - .NET Spreadsheet Control
 * 
 * https://reogrid.net/
 *
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
 * KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
 * PURPOSE.
 *
 * Author: Jingwood <jingwood at unvell.com>
 *
 * Copyright (c) 2012-2025 Jingwood, unvell.com, all rights reserved.
 * 
 ****************************************************************************/

#define VP_DEBUG

using System.Collections.Generic;
using System.Diagnostics;

#if WINFORM || ANDROID
using RGFloat = System.Single;
using RGIntDouble = System.Int32;

#elif WPF
using RGFloat = System.Double;
using RGIntDouble = System.Double;

#elif iOS
using RGFloat = System.Double;
using RGIntDouble = System.Double;

#endif

using unvell.ReoGrid.Graphics;
using unvell.ReoGrid.Rendering;
using unvell.ReoGrid.Interaction;
using unvell.ReoGrid.Main;

namespace unvell.ReoGrid.Views
{
	interface IViewport : IView
	{
		Point ViewStart { get; set; }
		RGFloat ViewTop { get; }
		RGFloat ViewLeft { get; }
		//RGFloat ViewRight { get; }
		//RGFloat ViewBottom { get; }

		RGFloat ScrollX { get; set; }
		RGFloat ScrollY { get; set; }
		RGFloat ScrollViewTop { get; }
		RGFloat ScrollViewLeft { get; }

		ScrollDirection ScrollableDirections { get; set; }
		void Scroll(RGFloat offX, RGFloat offY);

		void ScrollTo(RGFloat x, RGFloat y);

		GridRegion VisibleRegion { get; set; }
	}
}

