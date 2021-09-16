using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

namespace Kubird
{
    public class UIMainMenuKubirdDetail : MonoBehaviour
    {
        [Header("Text Body Part")]
        [SerializeField] TextMeshProUGUI m_TextBody;
        [SerializeField] TextMeshProUGUI m_TextHorn;
        [SerializeField] TextMeshProUGUI m_TextRostrum;
        [SerializeField] TextMeshProUGUI m_TextTail;
        [SerializeField] TextMeshProUGUI m_TextWing;
        [SerializeField] TextMeshProUGUI m_TextDecor;
        [SerializeField] TextMeshProUGUI m_TextFeet;
        [SerializeField] TextMeshProUGUI m_TextEyes;
        [SerializeField] TextMeshProUGUI m_TextLevel;

        [Header("Text Detail")]
        [SerializeField] TextMeshProUGUI m_TextHealth;
        [SerializeField] TextMeshProUGUI m_TextDamage;
        [SerializeField] TextMeshProUGUI m_TextAttackSpeed;

        private KubirdData m_KubirdData;

        private int m_IndexBody = 0;
        private int m_IndexHorn = 0;
        private int m_IndexRostrum = 0;
        private int m_IndexTail = 0;
        private int m_IndexWing = 0;
        private int m_IndexDecor = 0;
        private int m_IndexFeet = 0;
        private int m_IndexEyes = 0;

        private DatabaseManager m_DatabaseManager;

        private void Awake()
        {
            m_KubirdData = new KubirdData() { level = 1 };
            m_DatabaseManager = DatabaseManager.Instance;
        }

        private void Start()
        {
            m_DatabaseManager = DatabaseManager.Instance;
            OnKubirdDataChange();
        }

        public void OnButtonNextBodyClick()
        {
            m_IndexBody++;
            m_IndexBody = Mathf.Clamp(m_IndexBody, 0, 5);
            OnKubirdDataChange();
        }

        public void OnButtonNextHornClick()
        {
            m_IndexHorn++;
            m_IndexHorn = Mathf.Clamp(m_IndexHorn, 0, 15);
            OnKubirdDataChange();
        }

        public void OnButtonNextRostrumClick()
        {
            m_IndexRostrum++;
            m_IndexRostrum = Mathf.Clamp(m_IndexRostrum, 0, 15);
            OnKubirdDataChange();
        }

        public void OnButtonNextTailClick()
        {
            m_IndexTail++;
            m_IndexTail = Mathf.Clamp(m_IndexTail, 0, 15);
            OnKubirdDataChange();
        }

        public void OnButtonNextWingClick()
        {
            m_IndexWing++;
            m_IndexWing = Mathf.Clamp(m_IndexWing, 0, 15);
            OnKubirdDataChange();
        }

        public void OnButtonNextDecorClick()
        {
            m_IndexDecor++;
            m_IndexDecor = Mathf.Clamp(m_IndexDecor, 0, 15);
            OnKubirdDataChange();
        }

        public void OnButtonNextFeetClick()
        {
            m_IndexFeet++;
            m_IndexFeet = Mathf.Clamp(m_IndexFeet, 0, 15);
            OnKubirdDataChange();
        }

        public void OnButtonNextEyesClick()
        {
            m_IndexEyes++;
            m_IndexEyes = Mathf.Clamp(m_IndexEyes, 0, 15);
            OnKubirdDataChange();
        }

        public void OnButtonNextLevelClick()
        {
            m_KubirdData.level++;
            m_KubirdData.level = Mathf.Clamp(m_KubirdData.level, 0, 30);
            OnKubirdDataChange();
        }

        public void OnButtonPrevBodyClick()
        {
            m_IndexBody--;
            m_IndexBody = Mathf.Clamp(m_IndexBody, 0, 5);
            OnKubirdDataChange();
        }

        public void OnButtonPrevHornClick()
        {
            m_IndexHorn--;
            m_IndexHorn = Mathf.Clamp(m_IndexHorn, 0, 15);
            OnKubirdDataChange();
        }

        public void OnButtonPrevRostrumClick()
        {
            m_IndexRostrum--;
            m_IndexRostrum = Mathf.Clamp(m_IndexRostrum, 0, 15);
            OnKubirdDataChange();
        }

        public void OnButtonPrevTailClick()
        {
            m_IndexTail--;
            m_IndexTail = Mathf.Clamp(m_IndexTail, 0, 15);
            OnKubirdDataChange();
        }

        public void OnButtonPrevWingClick()
        {
            m_IndexWing--;
            m_IndexWing = Mathf.Clamp(m_IndexWing, 0, 15);
            OnKubirdDataChange();
        }

        public void OnButtonPrevDecorClick()
        {
            m_IndexDecor--;
            m_IndexDecor = Mathf.Clamp(m_IndexDecor, 0, 15);
            OnKubirdDataChange();
        }

        public void OnButtonPrevFeetClick()
        {
            m_IndexFeet--;
            m_IndexFeet = Mathf.Clamp(m_IndexFeet, 0, 15);
            OnKubirdDataChange();
        }

        public void OnButtonPrevEyesClick()
        {
            m_IndexEyes--;
            m_IndexEyes = Mathf.Clamp(m_IndexEyes, 0, 15);
            OnKubirdDataChange();
        }

        public void OnButtonPrevLevelClick()
        {
            m_KubirdData.level--;
            m_KubirdData.level = Mathf.Clamp(m_KubirdData.level, 0, 30);
            OnKubirdDataChange();
        }

        public void OnKubirdDataChange()
        {
            List<string> listEffect = new List<string>();
            var bodyPartData = m_DatabaseManager.bodyPartDataDict.GetPartData(BodyPartCategory.Body);

            if (bodyPartData == null) return;
            m_KubirdData.bodyId = bodyPartData.list[m_IndexBody];

            m_TextBody.text = "Body: " + m_KubirdData.bodyId;
            listEffect.Add(m_KubirdData.bodyId);

            var hornPartData = m_DatabaseManager.bodyPartDataDict.GetPartData(BodyPartCategory.Horn);

            if (hornPartData == null) return;
            m_KubirdData.hornId = hornPartData.list[m_IndexHorn];
            listEffect.Add(m_KubirdData.hornId);

            m_TextHorn.text = "Horn: " + m_KubirdData.hornId;

            var rostrumPartData = m_DatabaseManager.bodyPartDataDict.GetPartData(BodyPartCategory.Rostrum);

            if (rostrumPartData == null) return;
            m_KubirdData.rostrumId = rostrumPartData.list[m_IndexRostrum];
            listEffect.Add(m_KubirdData.rostrumId);

            m_TextRostrum.text = "Rostrum: " + m_KubirdData.rostrumId;

            var tailPartData = m_DatabaseManager.bodyPartDataDict.GetPartData(BodyPartCategory.Tail);

            if (tailPartData == null) return;
            m_KubirdData.tailId = tailPartData.list[m_IndexTail];
            listEffect.Add(m_KubirdData.tailId);

            m_TextTail.text = "Tail: " + m_KubirdData.tailId;

            var wingPartData = m_DatabaseManager.bodyPartDataDict.GetPartData(BodyPartCategory.Decor);

            if (wingPartData == null) return;
            m_KubirdData.wingId = wingPartData.list[m_IndexWing];
            listEffect.Add(m_KubirdData.wingId);

            m_TextWing.text = "Wing: " + m_KubirdData.wingId;

            var decorPartData = m_DatabaseManager.bodyPartDataDict.GetPartData(BodyPartCategory.Decor);

            if (decorPartData == null) return;
            m_KubirdData.decorId = decorPartData.list[m_IndexDecor];
            listEffect.Add(m_KubirdData.decorId);

            m_TextDecor.text = "Decor: " + m_KubirdData.decorId;

            var feetPartData = m_DatabaseManager.bodyPartDataDict.GetPartData(BodyPartCategory.Feet);

            if (feetPartData == null) return;
            m_KubirdData.feetId = feetPartData.list[m_IndexFeet];
            listEffect.Add(m_KubirdData.feetId);

            m_TextFeet.text = "Feet: " + m_KubirdData.feetId;

            var eyesPartData = m_DatabaseManager.bodyPartDataDict.GetPartData(BodyPartCategory.Eyes);

            if (eyesPartData == null) return;
            m_KubirdData.eyesId = eyesPartData.list[m_IndexEyes];
            listEffect.Add(m_KubirdData.eyesId);

            m_TextEyes.text = "Eyes: " + m_KubirdData.eyesId;

            m_TextLevel.text = "Level: " + m_KubirdData.level;


            var bodyBaseData = m_DatabaseManager.bodyDataDict.FirstOrDefault(b => b.bodyId == m_KubirdData.bodyId);

            if (bodyBaseData != null)
            {
                int inscreaseLevel = Mathf.Clamp(m_KubirdData.level - 1, 0, 30);
                float baseHealth = bodyBaseData.healthInit + (inscreaseLevel) * bodyBaseData.healthIncrease;
                float baseDamage = bodyBaseData.damageInit + (inscreaseLevel) * bodyBaseData.damageIncrease;
                float baseAttackSpeed = bodyBaseData.attackspeedInit + (inscreaseLevel) * bodyBaseData.attackspeedIncrease;

                float healthIncrease = 0;
                float damageIncrease = 0;
                float attackspeedIncrease = 0;

                foreach (var effectId in listEffect)
                {
                    foreach (var skillData in m_DatabaseManager.skillDataDict)
                    {
                        if (skillData.bodyPartId == effectId)
                        {
                            if (skillData.attribute == SkillAttribute.Health)
                            {
                                healthIncrease += skillData.valueType == SkillValueType.Absolute ? skillData.value : skillData.value * baseHealth / 100f;
                            }
                            else if (skillData.attribute == SkillAttribute.BulletPower)
                            {
                                damageIncrease += skillData.valueType == SkillValueType.Absolute ? skillData.value : skillData.value * baseHealth / 100f;
                            }
                            else if (skillData.attribute == SkillAttribute.AttackSpeed)
                            {
                                attackspeedIncrease += skillData.valueType == SkillValueType.Absolute ? skillData.value : skillData.value * baseHealth / 100f;
                            }
                        }
                    }
                }

                m_TextHealth.text = "Health: " + baseHealth + " <color=#008800> (+" + healthIncrease + ")";
                m_TextDamage.text = "Damage: " + baseDamage + " <color=#008800> (+" + damageIncrease + ")";
                m_TextAttackSpeed.text = "AttackSpped: " + baseAttackSpeed + " <color=#008800> (+" + attackspeedIncrease + ")";
            }
        }
    }
}