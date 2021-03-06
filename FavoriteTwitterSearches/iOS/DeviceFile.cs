﻿using System;
using System.IO;
using FavoriteTwitterSearches.iOS;

[assembly: Xamarin.Forms.Dependency (typeof (DeviceFile))]
namespace FavoriteTwitterSearches.iOS
{
	public class DeviceFile: IDeviceFile
	{
		public bool Exists(string path)
		{
			return File.Exists (path);
		}

		public void WriteAllText(string path, string contents)
		{
			File.WriteAllText (path, contents);
		}

		public string ReadAllText(string path)
		{
			return File.ReadAllText(path);
		}
	}
}

