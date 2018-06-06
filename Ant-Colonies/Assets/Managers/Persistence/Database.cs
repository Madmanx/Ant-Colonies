using System.Collections.Generic;
using UnityEngine;

using DatabaseClass;
using System;

namespace DatabaseClass
{

    [System.Serializable]
    public class ColorData : Unlockable
    {
        [SerializeField]
        public Color color;
    }
    
    

    [System.Serializable]
    public class Unlockable
    {
        //[HideInInspector]
        [SerializeField]
        private string id;

        [SerializeField]
        public bool isUnlocked = false;

        [SerializeField]
        public int costToUnlock = -1;

        public virtual string Id
        {
            get { return id; }
            set { id = value; }
        }

    }

    [CreateAssetMenu(fileName = "Database", menuName = "Custom/Database", order = 1)]
    [System.Serializable]
    public class Database : ScriptableObject
    {

       
        [SerializeField]
        public List<ColorData> colors;
       
        public void SetUnlock<T>(string _id, bool isUnlocked, int _version = 0) where T : Unlockable
        {
            if (typeof(T) == typeof(ColorData))
            {
                if (colors.Find(a => a.Id == _id) != null)
                    colors.Find(a => a.Id == _id).isUnlocked = isUnlocked;
            }
        }

        public Unlockable GetDataFromId<T>(string _id) where T : Unlockable
        {
            if (typeof(T) == typeof(ColorData))
                return colors.Find(a => a.Id == _id);
  
            return null;
        }

     

        public bool IsUnlock<T>(string _id, int _version = 0) where T : Unlockable
        {
            if (typeof(T) == typeof(ColorData))
            {
                if (colors.Find(a => a.Id == _id) != null)
                    return colors.Find(a => a.Id == _id).isUnlocked;
            }
          

            return false;
        }

      

        public void UnlockedAll()
        {
            foreach (Unlockable a in colors)
                a.isUnlocked = true;
        }

        public void ResetAll() {
            colors = new List<ColorData>();



            // Adding colors
            int idColors = 0;
            string[] strColor = { "Color 1",
                                "Color 2",
                                "Color 3",
                                "Color 4",
                                "Color 5",
                                "Color 6",
                                "Color 7",
                                "Color 8",
                                "Color 9",
                                "Color 10",
                                "Color 11",
                                "Color 12",
                                "Color 13",
                                "Color 14",
                                "Color 15",
                                "Color 16",
                                "Color 17",
                                "Color 18",
                                "White"
            };
            Color[] tabColor = { new Color(255, 197, 41, 255) / 255,
                                new Color(244, 230, 81, 255) / 255,
                                new Color(233, 152, 0, 255) / 255,
                                new Color(144, 27, 27, 255) / 255,
                                new Color(170, 247, 215, 255) / 255,
                                new Color(116, 205, 242, 255) / 255,
                                new Color(0, 147, 210, 255) / 255,
                                new Color(128, 131, 245, 255) / 255,
                                new Color(61, 65, 184, 255) / 255,
                                new Color(230, 181, 246, 255) / 255,
                                new Color(162, 77, 191, 255) / 255,
                                new Color(142, 223, 95, 255) / 255,
                                new Color(143, 216, 0, 255) / 255,
                                new Color(249, 142, 195, 255) / 255,
                                new Color(225, 121, 71, 255) / 255,
                                new Color(244, 59, 151, 255) / 255,
                                new Color(236, 108, 108, 255) / 255,
                                new Color(236, 81, 24, 255) / 255,
                                new Color(255, 255, 255, 255) / 255
            };
            colors.Add(new ColorData { Id = strColor[idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
            colors.Add(new ColorData { Id = strColor[++idColors], color = tabColor[idColors], isUnlocked = true });
        }

        public void NewGameSettings()
        {
            ResetAll();

            //DatabaseManager.instance.SaveData();
            //DatabaseManager.LoadData();

        }
    }

}