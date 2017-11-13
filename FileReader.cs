using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoDWWII_FoV_Fix
{
    static class FileReader
    {
        private static string _configPath = @"C:\Program Files (x86)\Steam\steamapps\common\Call of Duty WWII\players2\user_config_mp.cfg";

        private static string[] _userFile = File.ReadAllLines(_configPath);

        private static int _fovConfig = _userFile.Length -1;

        private static string _parsedConfig = ConfigParser();


        public static void SetFov(int inputFOV)
        {
            RemoveReadOnly();
            if (_parsedConfig != null)
            {
                for (int i = 0; i < _userFile.Length; i++)
                {
                    if(_userFile[i].Contains("seta cg_fov_override"))
                    {
                        _userFile[i] = $"seta cg_fov_override \"{inputFOV}\"";
                    }
                }
                File.WriteAllLines(_configPath,_userFile);
            }

            ReloadConfig();
            SetReadOnly();
        }

        private static void ReloadConfig()
        {
            _userFile = File.ReadAllLines(_configPath);
            _parsedConfig = ConfigParser();
        }

        public static int SetLabel()
        {
            
            if(_parsedConfig != null)
            {
                string parsedFoV = "";
                //check default
                if (_parsedConfig.Contains("-1"))
                    return Convert.ToInt32("65");

                for (int i = _parsedConfig.Length - 3; i < _parsedConfig.Length -1; i++)
                {
                    parsedFoV += _parsedConfig[i];
                }
               
                return Convert.ToInt32(parsedFoV);
            }

            return 0;
        }

        public static bool ConfirmChanges(int fovTrackValue)
        {
            
            return (fovTrackValue == SetLabel()) ? true : false;
        }

        public static string ConfigParser()
        {     
            //check if the last line is the proper one.
            if(_userFile[_fovConfig].Contains("seta cg_fov_override"))
            {
                
                return _userFile[_fovConfig];
            }
            else
            {
                //bruteforce check
                foreach (var item in _userFile)
                {
                    if (item.Contains("seta cg_fov_override"))
                    {
                      
                        return item;
                    }
                    
                }
            }

            return null;
        }

        private static void SetReadOnly()
        {
            FileAttributes attributes = File.GetAttributes(_configPath);

            if((attributes & FileAttributes.ReadOnly) != FileAttributes.ReadOnly)
            {
                File.SetAttributes(_configPath, FileAttributes.ReadOnly);
            }
        }

        private static void RemoveReadOnly()
        {
            FileAttributes attributes = File.GetAttributes(_configPath);

            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                attributes = attributes & ~FileAttributes.ReadOnly;
                File.SetAttributes(_configPath, attributes);
            }
        }


    }
}
