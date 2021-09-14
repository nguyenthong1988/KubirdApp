using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Kubird
{
    [Serializable]
    public class ProfileData
    {
        public string profileId;
        public string profileName;
        public SkinProfileData activeSkin;
        public List<SkinProfileData> skins;

        public void Init()
        {
            activeSkin = new SkinProfileData() { colorFamily = ColorFamily.Blue, id = 0 };
            skins = new List<SkinProfileData>();
            skins.Add(activeSkin);
        }
    }

    public class ProfileManager : MonoBehaviour
    {
        private readonly string ProfileSaveKey = "_profile_save_key";

        public static ProfileManager Instance = null;
        public bool initialized { get; protected set; } = false;

        private ProfileData m_ProfileData = null;

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            LoadProfile();

            initialized = true;
        }

        private void LoadProfile()
        {
            string profileDataString = PlayerPrefs.GetString(ProfileSaveKey, "");
            m_ProfileData = JsonUtility.FromJson<ProfileData>(profileDataString);

            if (m_ProfileData == null)
            {
                m_ProfileData = new ProfileData();
                SaveProfile();
            }
        }

        private void SaveProfile()
        {
            string profileDataString = JsonUtility.ToJson(m_ProfileData);
            PlayerPrefs.SetString(ProfileSaveKey, profileDataString);
            PlayerPrefs.Save();
        }    
    }
}