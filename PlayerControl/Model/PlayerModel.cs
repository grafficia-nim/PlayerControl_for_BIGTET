﻿using Newtonsoft.Json;
using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PlayerControl.Model
{
    public class PlayerModel : BindableBase
    {
        public ReactivePropertySlim<String> Name { get; } = new ReactivePropertySlim<string>(String.Empty);
        public ReactivePropertySlim<int> PersonalBest { get; } = new ReactivePropertySlim<int>(0);
        public ReactivePropertySlim<int> TodayBest { get; } = new ReactivePropertySlim<int>(0);
        public ReactivePropertySlim<DateTime> LastAccess { get; } = new ReactivePropertySlim<DateTime>(DateTime.MinValue);

        public PlayerModel()
        {

        }
        public PlayerModel(String name, int personalbest, int todaybest )
        {
            Name.Value = name;
            PersonalBest.Value = personalbest;
            TodayBest.Value = todaybest;
            LastAccess.Value = DateTime.Now;
        }
	}

	public class StreamControlParam
	{
		public StreamControlParam()
		{
			timestamp = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
		}
		public String pCountry1 { get; set; } = String.Empty;
		public String pCountry2 { get; set; } = String.Empty;
		public String pName1 { get; set; } = String.Empty;
		public String pName2 { get; set; } = String.Empty;
		public String pScore1 { get; set; } = String.Empty;
		public String pScore2 { get; set; } = String.Empty;
		public String stage { get; set; } = String.Empty;
		public String timestamp { get; set; } = "0";
	}
}