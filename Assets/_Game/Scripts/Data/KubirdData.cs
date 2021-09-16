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
    public class KubirdData
    {
        public ColorFamily colorFamily;
        public int id;
        public int level;
        public int levelPoint;
        public string bodyId;
        public string hornId;
        public string rostrumId;
        public string tailId;
        public string wingId;
        public string decorId;
        public string feetId;
        public string eyesId;
    }
}
