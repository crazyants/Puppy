﻿#region	License

//------------------------------------------------------------------------------------------------
// <License>
//     <Copyright> 2017 © Top Nguyen → AspNetCore → Puppy </Copyright>
//     <Url> http://topnguyen.net/ </Url>
//     <Author> Top </Author>
//     <Project> Puppy </Project>
//     <File>
//         <Name> DeviceAddOptions.cs </Name>
//         <Created> 30/05/2017 4:40:20 PM </Created>
//         <Key> 0e50bd87-394d-474f-8e6c-c217b0696cf1 </Key>
//     </File>
//     <Summary>
//         DeviceAddOptions.cs
//     </Summary>
// <License>
//------------------------------------------------------------------------------------------------

#endregion License

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Puppy.OneSignal.Devices
{
    /// <summary>
    ///     Options for adding new device to OneSignal app. 
    /// </summary>
    public class DeviceAddOptions
    {
        /// <summary>
        ///     Your OneSignal application ID, which can be found on our dashboard at onesignal.com
        ///     under App Settings &gt; Keys &amp; IDs. It is a UUID and looks similar to 8250eaf6-1a58-489e-b136-7c74a864b434.
        /// </summary>
        [JsonProperty("app_id")]
        public Guid AppId { get; set; }

        /// <summary>
        ///     0 = iOS 1 = Android 2 = Amazon 3 = WindowsPhone(MPNS) 4 = ChromeApp 5 = ChromeWebsite
        ///     6 = WindowsPhone(WNS) 7 = Safari 8 = Firefox 9 = Mac OS X
        /// </summary>
        [JsonProperty("device_type")]
        public DeviceTypeEnum DeviceType { get; set; }

        /// <summary>
        ///     Push notification identifier from Google or Apple. For Apple push identifiers, you
        ///     must strip all non alphanumeric characters.
        ///     Example: ce777617da7f548fe7a9ab6febb56
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        ///     Language code. Typically lower case two letters, except for Chinese where it must be
        ///     one of "zh-Hans" or "zh-Hant". Example: en
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        ///     Number of seconds away from UTC. Example: -28800 
        /// </summary>
        [JsonProperty("timezone")]
        public int? Timezone { get; set; }

        /// <summary>
        ///     Version of the app. 
        /// </summary>
        [JsonProperty("game_version")]
        public string GameVersion { get; set; }

        /// <summary>
        ///     Device make and model. Example: iPhone5,1 
        /// </summary>
        [JsonProperty("device_model")]
        public string DeviceModel { get; set; }

        /// <summary>
        ///     Device operating system version. Example: 7.0.4 
        /// </summary>
        [JsonProperty("device_os")]
        public string DeviceOS { get; set; }

        /// <summary>
        ///     Android = The Advertising Id iOS = The identifierForVendor WP8.0 = The DeviceUniqueId
        ///     WP8.1 = The AdvertisingId
        /// </summary>
        [JsonProperty("ad_id")]
        public string AdId { get; set; }

        /// <summary>
        ///     Name and version of the plugin that's calling this API method (if any) 
        /// </summary>
        [JsonProperty("sdk")]
        public string SDK { get; set; }

        /// <summary>
        ///     Number of times the user has played the game, defaults to 1 
        /// </summary>
        [JsonProperty("session_count")]
        public string SessionCount { get; set; }

        /// <summary>
        ///     Custom tags for the player.
        ///     Example: {"foo":"bar","this":"that"}
        /// </summary>
        [JsonProperty("tags")]
        public IDictionary<string, object> Tags { get; set; }

        /// <summary>
        ///     Amount the user has spent in USD, up to two decimal places 
        /// </summary>
        [JsonProperty("amount_spent")]
        public string AmountSpent { get; set; }

        /// <summary>
        ///     Unixtime when the player joined the game 
        /// </summary>
        [JsonProperty("created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        ///     Seconds player was running your app. 
        /// </summary>
        [JsonProperty("playtime")]
        public int? PlayTime { get; set; }

        /// <summary>
        ///     Current iOS badge count displayed on the app icon 
        /// </summary>
        [JsonProperty("badge_count")]
        public int? BadgeCount { get; set; }

        /// <summary>
        ///     Unixtime when the player was last active 
        /// </summary>
        [JsonProperty("last_active")]
        public int? LastActive { get; set; }

        /// <summary>
        ///     This is used in deciding whether to use your iOS Sandbox or Production push
        ///     certificate when sending a push when both have been uploaded. Set to the iOS
        ///     provisioning profile that was used to build your app. 1 = Development 2 = Ad-Hoc.
        ///     Omit this field for App Store builds.
        /// </summary>
        [JsonProperty("test_type")]
        public TestTypeEnum? TestType { get; set; }
    }
}