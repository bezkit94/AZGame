// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by the Game Data Editor.
//
//      Changes to this file will be lost if the code is regenerated.
//
//      This file was generated from this data file:
//      D:\UnityProjectsGit\AZGame\AZGame\Assets/Packages/GameDataEditor/Resources/gde_data.txt
//  </autogenerated>
// ------------------------------------------------------------------------------
using UnityEngine;
using System;
using System.Collections.Generic;

using GameDataEditor;

namespace GameDataEditor
{
    public class GDEMonstersData : IGDEData
    {
        static string BasicMeleeKey = "BasicMelee";
		float _BasicMelee;
        public float BasicMelee
        {
            get { return _BasicMelee; }
            set {
                if (_BasicMelee != value)
                {
                    _BasicMelee = value;
					GDEDataManager.SetFloat(_key, BasicMeleeKey, _BasicMelee);
                }
            }
        }

        static string BasicDistanceKey = "BasicDistance";
		float _BasicDistance;
        public float BasicDistance
        {
            get { return _BasicDistance; }
            set {
                if (_BasicDistance != value)
                {
                    _BasicDistance = value;
					GDEDataManager.SetFloat(_key, BasicDistanceKey, _BasicDistance);
                }
            }
        }

        static string BasicMagicKey = "BasicMagic";
		float _BasicMagic;
        public float BasicMagic
        {
            get { return _BasicMagic; }
            set {
                if (_BasicMagic != value)
                {
                    _BasicMagic = value;
					GDEDataManager.SetFloat(_key, BasicMagicKey, _BasicMagic);
                }
            }
        }

        static string MonsterNameKey = "MonsterName";
		string _MonsterName;
        public string MonsterName
        {
            get { return _MonsterName; }
            set {
                if (_MonsterName != value)
                {
                    _MonsterName = value;
					GDEDataManager.SetString(_key, MonsterNameKey, _MonsterName);
                }
            }
        }

        static string MonsterTypeKey = "MonsterType";
		string _MonsterType;
        public string MonsterType
        {
            get { return _MonsterType; }
            set {
                if (_MonsterType != value)
                {
                    _MonsterType = value;
					GDEDataManager.SetString(_key, MonsterTypeKey, _MonsterType);
                }
            }
        }

        static string MonsterDescriptionKey = "MonsterDescription";
		string _MonsterDescription;
        public string MonsterDescription
        {
            get { return _MonsterDescription; }
            set {
                if (_MonsterDescription != value)
                {
                    _MonsterDescription = value;
					GDEDataManager.SetString(_key, MonsterDescriptionKey, _MonsterDescription);
                }
            }
        }

        static string DifficultyLevelKey = "DifficultyLevel";
		string _DifficultyLevel;
        public string DifficultyLevel
        {
            get { return _DifficultyLevel; }
            set {
                if (_DifficultyLevel != value)
                {
                    _DifficultyLevel = value;
					GDEDataManager.SetString(_key, DifficultyLevelKey, _DifficultyLevel);
                }
            }
        }

        public GDEMonstersData(string key) : base(key)
        {
            GDEDataManager.RegisterItem(this.SchemaName(), key);
        }
        public override Dictionary<string, object> SaveToDict()
		{
			var dict = new Dictionary<string, object>();
			dict.Add(GDMConstants.SchemaKey, "Monsters");
			
            dict.Merge(true, BasicMelee.ToGDEDict(BasicMeleeKey));
            dict.Merge(true, BasicDistance.ToGDEDict(BasicDistanceKey));
            dict.Merge(true, BasicMagic.ToGDEDict(BasicMagicKey));
            dict.Merge(true, MonsterName.ToGDEDict(MonsterNameKey));
            dict.Merge(true, MonsterType.ToGDEDict(MonsterTypeKey));
            dict.Merge(true, MonsterDescription.ToGDEDict(MonsterDescriptionKey));
            dict.Merge(true, DifficultyLevel.ToGDEDict(DifficultyLevelKey));
            return dict;
		}

        public override void UpdateCustomItems(bool rebuildKeyList)
        {
        }

        public override void LoadFromDict(string dataKey, Dictionary<string, object> dict)
        {
            _key = dataKey;

			if (dict == null)
				LoadFromSavedData(dataKey);
			else
			{
                dict.TryGetFloat(BasicMeleeKey, out _BasicMelee);
                dict.TryGetFloat(BasicDistanceKey, out _BasicDistance);
                dict.TryGetFloat(BasicMagicKey, out _BasicMagic);
                dict.TryGetString(MonsterNameKey, out _MonsterName);
                dict.TryGetString(MonsterTypeKey, out _MonsterType);
                dict.TryGetString(MonsterDescriptionKey, out _MonsterDescription);
                dict.TryGetString(DifficultyLevelKey, out _DifficultyLevel);
                LoadFromSavedData(dataKey);
			}
		}

        public override void LoadFromSavedData(string dataKey)
		{
			_key = dataKey;
			
            _BasicMelee = GDEDataManager.GetFloat(_key, BasicMeleeKey, _BasicMelee);
            _BasicDistance = GDEDataManager.GetFloat(_key, BasicDistanceKey, _BasicDistance);
            _BasicMagic = GDEDataManager.GetFloat(_key, BasicMagicKey, _BasicMagic);
            _MonsterName = GDEDataManager.GetString(_key, MonsterNameKey, _MonsterName);
            _MonsterType = GDEDataManager.GetString(_key, MonsterTypeKey, _MonsterType);
            _MonsterDescription = GDEDataManager.GetString(_key, MonsterDescriptionKey, _MonsterDescription);
            _DifficultyLevel = GDEDataManager.GetString(_key, DifficultyLevelKey, _DifficultyLevel);
        }

        public GDEMonstersData ShallowClone()
		{
			string newKey = Guid.NewGuid().ToString();
			GDEMonstersData newClone = new GDEMonstersData(newKey);

            newClone.BasicMelee = BasicMelee;
            newClone.BasicDistance = BasicDistance;
            newClone.BasicMagic = BasicMagic;
            newClone.MonsterName = MonsterName;
            newClone.MonsterType = MonsterType;
            newClone.MonsterDescription = MonsterDescription;
            newClone.DifficultyLevel = DifficultyLevel;

            return newClone;
		}

        public GDEMonstersData DeepClone()
		{
			GDEMonstersData newClone = ShallowClone();
            return newClone;
		}

        public void Reset_BasicMelee()
        {
            GDEDataManager.ResetToDefault(_key, BasicMeleeKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(BasicMeleeKey, out _BasicMelee);
        }

        public void Reset_BasicDistance()
        {
            GDEDataManager.ResetToDefault(_key, BasicDistanceKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(BasicDistanceKey, out _BasicDistance);
        }

        public void Reset_BasicMagic()
        {
            GDEDataManager.ResetToDefault(_key, BasicMagicKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(BasicMagicKey, out _BasicMagic);
        }

        public void Reset_MonsterName()
        {
            GDEDataManager.ResetToDefault(_key, MonsterNameKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(MonsterNameKey, out _MonsterName);
        }

        public void Reset_MonsterType()
        {
            GDEDataManager.ResetToDefault(_key, MonsterTypeKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(MonsterTypeKey, out _MonsterType);
        }

        public void Reset_MonsterDescription()
        {
            GDEDataManager.ResetToDefault(_key, MonsterDescriptionKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(MonsterDescriptionKey, out _MonsterDescription);
        }

        public void Reset_DifficultyLevel()
        {
            GDEDataManager.ResetToDefault(_key, DifficultyLevelKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(DifficultyLevelKey, out _DifficultyLevel);
        }

        public void ResetAll()
        {
            GDEDataManager.ResetToDefault(_key, MonsterNameKey);
            GDEDataManager.ResetToDefault(_key, MonsterTypeKey);
            GDEDataManager.ResetToDefault(_key, MonsterDescriptionKey);
            GDEDataManager.ResetToDefault(_key, DifficultyLevelKey);
            GDEDataManager.ResetToDefault(_key, BasicMeleeKey);
            GDEDataManager.ResetToDefault(_key, BasicDistanceKey);
            GDEDataManager.ResetToDefault(_key, BasicMagicKey);


            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            LoadFromDict(_key, dict);
        }
    }
}
