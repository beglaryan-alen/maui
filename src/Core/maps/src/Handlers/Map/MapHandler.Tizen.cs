﻿using System;
using Microsoft.Maui.Handlers;

namespace Microsoft.Maui.Maps.Handlers
{
	public partial class MapHandler : ViewHandler<IMap, ElmSharp.EvasObject>
	{

		protected override ElmSharp.EvasObject CreatePlatformView() => throw new NotImplementedException();

		public static void MapMapType(IMapHandler handler, IMap map) => throw new NotImplementedException();

		public static void MapIsShowingUser(IMapHandler handler, IMap map) => throw new NotImplementedException();

		public static void MapHasScrollEnabled(IMapHandler handler, IMap map) => throw new NotImplementedException();


		public static void MapHasTrafficEnabled(IMapHandler handler, IMap map) => throw new NotImplementedException();

		public static void MapHasZoomEnabled(IMapHandler handler, IMap map) => throw new NotImplementedException();

		public static void MapMoveToRegion(IMapHandler handler, IMap map, object? arg) => throw new NotImplementedException();

		public static void MapPins(IMapHandler handler, IMap map) => throw new NotImplementedException();

		public static void MapElements(IMapHandler handler, IMap map) => throw new NotImplementedException();

		public void UpdateMapElement(IMapElement element) => throw new NotImplementedException();
	}
}
