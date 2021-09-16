using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Kubird
{
    [Serializable]
    public class BodyData
    {
        [JsonProperty("id")]
        public string bodyId;

        [JsonProperty("health_init")]
        public float healthInit;

        [JsonProperty("health_increase")]
        public float healthIncrease;

        [JsonProperty("damage_init")]
        public float damageInit;

        [JsonProperty("damage_increase")]
        public float damageIncrease;

        [JsonProperty("attackspeed_init")]
        public float attackspeedInit;

        [JsonProperty("attackspeed_increase")]
        public float attackspeedIncrease;
    }
}
