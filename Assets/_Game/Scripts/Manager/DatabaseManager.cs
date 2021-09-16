using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Kubird
{
    public class DatabaseManager : MonoBehaviour
    {
        private static readonly string LocalSkillDatabasePath = "JsonData/SkillMap";

        public static DatabaseManager Instance = null;
        public bool initialized { get; protected set; } = false;

        [HideInInspector]
        public List<SkillData> skillDataDict;
        [HideInInspector]
        public List<BodyData> bodyDataDict;

        [Header("Reference")]
        public BodyPartDataDict bodyPartDataDict;

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            StartCoroutine(CorInit());
        }

        private IEnumerator CorInit()
        {
            LoadDatabaseSkill();

            yield return new WaitUntil(() => skillDataDict != null);

            LoadDatabaseBody();

            yield return new WaitUntil(() => bodyDataDict != null);

            initialized = true;
        }

        private void LoadDatabaseSkill()
        {
            var textAsset = Resources.Load<TextAsset>("JsonData/SkillMap");
            if (textAsset != null)
            {
                string rawData = textAsset.text;
                skillDataDict = JsonConvert.DeserializeObject<List<SkillData>>(rawData);
                foreach (var skillData in skillDataDict)
                {
                    skillData.Validate();
                }
            }

            Resources.UnloadAsset(textAsset);
        }

        private void LoadDatabaseBody()
        {
            var textAsset = Resources.Load<TextAsset>("JsonData/BodyMap");
            if (textAsset != null)
            {
                string rawData = textAsset.text;
                bodyDataDict = JsonConvert.DeserializeObject<List<BodyData>>(rawData);
            }

            Resources.UnloadAsset(textAsset);
        }

        public List<SkillData> GetAllSkillData(string bodyPartId)
        {
            if (skillDataDict != null)
            {
                return skillDataDict.FindAll(s => s.bodyPartId == bodyPartId);
            }

            return null;
        }
    }
}