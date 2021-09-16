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
    public enum SkillType { Active, Passive }
    public enum SkillTarget { Unknown, Self, Main, Sub, Mob, Boss }
    public enum SkillAttribute { Unknown, Health, BulletPower, BulletSpeed, AttackSpeed, MoveSpeed }
    public enum SkillValueType { Absolute, Percent }

    [Serializable]
    public class SkillData
    {
        [JsonProperty("id")]
        public string bodyPartId;

        [JsonProperty("type")]
        public SkillType skillType;

        [JsonProperty("target")]
        public string targetString;

        [JsonIgnore]
        public SkillTarget target;

        [JsonProperty("attribute")]
        public string attributeString;

        [JsonIgnore]
        public SkillAttribute attribute;

        [JsonProperty("value")]
        public float value;

        [JsonProperty("value_type")]
        public SkillValueType valueType;

        public void Validate()
        {
            target = TranslateSkillTarget(targetString);
            attribute = TranslateSkillAttribute(attributeString);
        }

        public static SkillTarget TranslateSkillTarget(string target) => target switch
        {
            "self" => SkillTarget.Main,
            "main" => SkillTarget.Main,
            "sub" => SkillTarget.Sub,
            "mob" => SkillTarget.Mob,
            "boss" => SkillTarget.Boss,
            _ => SkillTarget.Unknown,
        };

        public static SkillAttribute TranslateSkillAttribute(string attribute) => attribute switch
        {
            "health" => SkillAttribute.Health,
            "bullet_power" => SkillAttribute.BulletPower,
            "bullet_speed" => SkillAttribute.BulletSpeed,
            "attack_speed" => SkillAttribute.AttackSpeed,
            "move_speed" => SkillAttribute.MoveSpeed,
            _ => SkillAttribute.Unknown,
        };
    }
}
